namespace SQL.CLR.RegEx.Functions
{
    using Microsoft.SqlServer.Server;
    using System.Data.SqlTypes;
    using System.Data.SqlClient;
    using System.Text.RegularExpressions;

    public struct RegExFunction
    {
        /// <summary>
        /// Returns any matches for the pattern.
        /// </summary>
        /// <param name="pattern">The RegEx pattern to match.</param>
        /// <param name="expression">The string to search.</param>
        /// <returns>SqlString     The match found.</returns>
        public static SqlString Match(string pattern, string expression)
        {
            var result = new Regex(pattern).Match(expression).Value;
            return result.Equals("") ? SqlString.Null : new SqlString(result);
        }

        /// <summary>
        /// Returns the position the match was found at.
        /// </summary>
        /// <param name="pattern">The RegEx pattern to match.</param>
        /// <param name="expression">The string to search.</param>
        /// <returns>SqlInt32    The position the match was found at.</returns>
        public static SqlInt32 MatchPosition(string pattern, string expression)
        {
            var result = new Regex(pattern).Match(expression);
            return !result.Success ? -1 : new SqlInt32(result.Index);
        }

        /// <summary>
        /// Returns the length of the match.
        /// </summary>
        /// <param name="pattern">RegEx pattern to match.</param>
        /// <param name="expression">The string to search.</param>
        /// <returns>SqlInt32    The length of the match.</returns>
        public static SqlInt32 MatchLength(string pattern, string expression)
        {
            return new SqlInt32(new Regex(pattern).Match(expression).Length);
        }

        /// <summary>
        /// Returns the new string if any replacements are made.
        /// </summary>
        /// <param name="pattern">The pattern to match.</param>
        /// <param name="expression">The string to search.</param>
        /// <param name="replacement">The value to replace the match(es) with.</param>
        /// <returns>SqlString     The modified string.</returns>
        public static SqlString Replace(string pattern, string expression, string replacement)
        {
            return new SqlString(new Regex(pattern).Replace(expression, replacement));
        }
    }
}
