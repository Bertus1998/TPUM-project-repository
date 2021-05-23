using System;
using System.Threading.Tasks;
namespace Data
{
   public abstract class WebSocketConnection
    {
 
        public virtual Action<string> onMessage { set; protected get; } = x => {  WebSocketManager.realize(x); };
        public virtual Action onClose { set; protected get; } = () => { };
        public virtual Action onError { set; protected get; } = () => { };
        internal async Task SendAsync(string message)
        {
            await SendTask(message);
        }
        protected abstract Task SendTask(string message);
        internal abstract Task DisconnectAsync();

        internal void SendAsync()
        {
            throw new NotImplementedException();
        }
    }
}