using System;
using System.Collections.Generic;
using System.Text;

namespace DotaMatchupFinder.Core.QueryBuilders
{
    public class SearchBuilder
    {
        private StringBuilder _queryBuilder = new StringBuilder();
        private StringBuilder _selectBuilder;
        private StringBuilder _fromBuilder;
        private StringBuilder _joinBuilder;
        private StringBuilder _whereBuilder;
        private StringBuilder _limitBuilder;

        public SearchBuilder Select(string item = "*")
        {
            if (_selectBuilder == null)
            {
                _selectBuilder = new StringBuilder();
                _selectBuilder.Append($"{item}");
            }
            else
            {
                _selectBuilder.Append($", {item}");
            }

            return this;
        }
        public SearchBuilder Select(params string[] items)
        {
            foreach(var item in items)
            {
                Select(item);
            }

            return this;
        }


        public SearchBuilder From(string item, string itemAs = null)
        {
            if (_fromBuilder == null) _fromBuilder = new StringBuilder();
            _fromBuilder.Append(item);
            if(itemAs != null)
            {
                _fromBuilder.Append($" AS {itemAs}");
            }

            return this;
        }


        public SearchBuilder Join(string item, string itemUsing)
        {
            if (_joinBuilder == null) _joinBuilder = new StringBuilder();
            _joinBuilder.Append(item);
            if (itemUsing != null)
            {
                _fromBuilder.Append($" using({itemUsing})");
            }

            return this;
        }


        public SearchBuilder Where(string expression)
        {
            if (_whereBuilder == null)
            {
                _whereBuilder = new StringBuilder();
                _whereBuilder.AppendLine($"{expression}");
            }
            else
            {
                _whereBuilder.AppendLine($"AND {expression}");
            }

            return this;
        }


        public string BuildQuery()
        {
            _queryBuilder.AppendLine($"SELECT {_selectBuilder?.ToString() ?? "*"} ");
            _queryBuilder.AppendLine($"FROM {_fromBuilder?.ToString() ?? "public_player_matches"} ");
            if (_joinBuilder != null)
            {
                _queryBuilder.AppendLine($"JOIN {_joinBuilder} ");
            }
            _queryBuilder.AppendLine($"WHERE {_whereBuilder?.ToString() ?? "TRUE"} ");
            _queryBuilder.AppendLine($"LIMIT {_limitBuilder?.ToString() ?? "10"} ");

            return _queryBuilder.ToString();
        }

    }
}
