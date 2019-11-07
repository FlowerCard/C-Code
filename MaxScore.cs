class MaxScore
    {
        static void Main(string[] args)
        {
            string[,] info = new string[8, 2]
            {
                {"吴松","89" },{"钱东宇","90" },{"伏晨","98"},{"陈陆","56"},{"周蕊","60"},{"林日鹏","9" },{"何昆","93" },{"关欣","85"}
            };
            string name = "";
            string score = "";
            for(int i=0; i<8; i++)
            {
                if (String.Compare(info[i, 1], score) > 0)
                {
                    score = info[i, 1];
                    name = info[i, 0];
                }
            }
            Console.WriteLine("分数最高的是" + name + "，分数是" + score);
        }
    }
