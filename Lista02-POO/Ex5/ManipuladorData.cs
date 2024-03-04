namespace Lista02_POO.Ex5
{
    public class ManipuladorData
    {
        public int CalcularDiferencaDias(DateTime data1, DateTime data2)
        {
            if (data1 > data2)
            {
                return (int)data1.Subtract(data2).TotalDays;
            }

            if (data2 > data1)
            {
                return (int)data2.Subtract(data1).TotalDays;
            }

            return 0;
        }
    }
}