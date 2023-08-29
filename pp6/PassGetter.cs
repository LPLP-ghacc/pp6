namespace pp6
{
    public class PassGetter
    {
        private Random random = new Random();

        public char[] array = "!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~".ToCharArray();

        public PassGetter(Random random) 
        {
            this.random = random;
        }

        public List<string> Get(int count)
        {
            Func<char[], Task<string>> printer = async (array) =>
            {
                return await Task.Run(() => GetPass(array));
            };

            var result = new List<string>();

            for (int i = 0; i < count; i++)
            {
                result.Add(printer(array).Result);
            }

            return result;
        }

        private string GetPass(char[] array)
        {
            string rndword = string.Empty;

            for (int i = 0; i < random.Next(6, 32); i++)
            {
                rndword += array[random.Next(0, array.Length)];
            }

            return rndword;
        }

        public void CreateNewFile((int, string) value)
        {
            var list = Get(value.Item1);

            File.Create(value.Item2).Close();

            object fileLock = new object();

            list.ForEach(x =>
            {
                lock (fileLock)
                {
                    File.AppendAllText(value.Item2, x + Environment.NewLine);
                }
            });
        }
    }
}
