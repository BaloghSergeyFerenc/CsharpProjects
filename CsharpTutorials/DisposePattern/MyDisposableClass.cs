using System;
using System.IO;

namespace DisposePattern
{
    internal class MyDisposableClass : IDisposable
    {
        #region Fields
        //Subscription
        private MyEventProvider provider;
        //Disposable refence
        private StreamWriter streamWriter;
        //Unmanaged resource
        /*... and additional database relevant fields as well */
        #endregion Fields

        #region Public
        public MyDisposableClass(MyEventProvider provider)
        {
            this.provider = provider;
            provider.MyEvent += MyHandler;
            streamWriter = new StreamWriter("c:\abc.txt");
            FetchUnmanagedResoure();
        }

        //Disposable object usage
        public void WriteFile(string content)
        {
            streamWriter.WriteLine(content);
        }

        //Unmanaged Resource usage
        public void StoreToDatabase(/*parameters to data store*/)
        {
            //Implementation
        }
        #endregion Public

        #region Private
        //Unmanaged Resoure handler
        private void FetchUnmanagedResoure()
        {
            //Fetching e.g. database
        }

        //Unmanaged Resoure handler
        private void ReleaseUnmanagedResource()
        {
            //Relese the unmanaged resource here, e.g. database
        }

        //Event handler of this class
        private void MyHandler()
        {
            //Implementation
        }

        #region IDisposable Support
        // To detect redundant calls
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    streamWriter.Flush();
                    streamWriter.Close();
                    streamWriter.Dispose();

                    //Discriptions
                    provider.MyEvent -= MyHandler;
                    provider = null;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                ReleaseUnmanagedResource();

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~MyDisposableClass()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion IDisposable Support
        #endregion Private
    }
}
