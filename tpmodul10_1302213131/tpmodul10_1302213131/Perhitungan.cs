namespace tpmodul10_1302213131
{
    public class Perhitungan
    {
        public static (double,double) AkarPersamaanKuadrat(double[] persamaan)
        {
            double x1,x2;
            double akar = Math.Sqrt((persamaan[1] * persamaan[1]) - (4 * persamaan[0] * persamaan[2]));
            x1 = -persamaan[1] + akar / (2 * persamaan[0]);
            x2 = -persamaan[1] - akar / (2 * persamaan[0]);
            return (x1,x2);
        }
        public static (double,double,double) HasilKuadrat(double[] persamaan)
        {
            double x1, x2, x3;
            x1 = persamaan[0] * persamaan[0];
            x2 = (persamaan[1] * persamaan[0]) + (persamaan[0] * persamaan[1]);
            x3 = persamaan[1] * persamaan[1];
            return (x1,x2,x3);
        }
    }
}