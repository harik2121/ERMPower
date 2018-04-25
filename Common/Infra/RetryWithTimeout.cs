namespace ERMPower.common.Infra
{
    public abstract class RetryWithTimeout<T>
    {
        protected int NumOfRetries;
        protected int TimeoutMilliseconds;

        public RetryWithTimeout<T> WithRetry(int numOfRetries)
        {
            NumOfRetries = numOfRetries;
            return this;
        }

        public RetryWithTimeout<T> WithTimeout(int timeoutMilliseconds)
        {
            TimeoutMilliseconds = timeoutMilliseconds;
            return this;
        }

        public abstract T Execute();
    }
}
