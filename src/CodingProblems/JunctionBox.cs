namespace CodingProblems
{
    internal class JunctionBox
    {
        private const char FIELD_DELIMITER = ' ';
        private readonly string[] _splittedVersion;

        private JunctionBox(string junctionBoxStr)
        {
            var idAndVersion = junctionBoxStr.Split(FIELD_DELIMITER);
            _splittedVersion = new string[idAndVersion.Length - 1];

            for (var i = 0; i < idAndVersion.Length; i++)
            {
                if (i == 0)
                {
                    Id = idAndVersion[i];
                }
                else
                {
                    _splittedVersion[i - 1] = idAndVersion[i];
                }
            }

            if (IsNewGeneration())
            {
                Generation = JunctionBoxGeneration.New;
            }
            else
            {
                Generation = JunctionBoxGeneration.Old;
            }
        }

        internal enum JunctionBoxGeneration
        {
            Old, New
        }

        public string Id { get; set; }

        public string Version => string.Join(FIELD_DELIMITER, _splittedVersion);

        public JunctionBoxGeneration Generation { get; set; }

        public static JunctionBox From(string junctionBoxStr)
        {
            return new JunctionBox(junctionBoxStr);
        }

        private bool IsNewGeneration()
        {
            return int.TryParse(_splittedVersion[0], out _);
        }
    }
}