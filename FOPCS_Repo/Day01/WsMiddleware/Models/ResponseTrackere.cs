namespace WsMiddleware.Models
{
    public class ResponseTrackere
    {
        private double totalReadTime;
        private int nReads;
        private double totalWriteTime;
        private int nWrites;
        public void StoreDuration(string path, double duration)
        {
            if (path.Contains("Read"))
            {
                totalReadTime += duration;
                nReads++;
            }
            else if (path.Contains("Write"))
            {
                totalWriteTime += duration;
                nWrites++;
            }
        }

        public double GetAvgReadTime()
        {
            if (nReads == 0)
            {
                return 0.0;
            }

            return totalReadTime / nReads;
        }

        public double GetAvgWriteTime()
        {
            if (nWrites == 0)
            {
                return 0.0;
            }

            return totalWriteTime / nWrites;
        }
    }
}
