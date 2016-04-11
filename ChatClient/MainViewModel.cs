using ChatClient.Models;
using Microsoft.AspNet.SignalR.Client;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatClient
{
    public class MainViewModel : BindableBase
    {
        #region Private Fields

        private HubConnection _hubConnection;
        private IHubProxy _hubProxy;

        #endregion

        #region Constructors

        public MainViewModel()
        {
            this.Contents = new ObservableCollection<ChatContent>();
            this.Append = new DelegateCommand(this.AppendExecute);
            _hubConnection = new HubConnection("http://localhost:13842/");
            _hubProxy = _hubConnection.CreateHubProxy("ChatHub");
            _hubProxy.On<string, string>("AppendMessage", (x, y) => 
            {
                this.Contents.Add(new ChatContent { Name = x, Content = y});
            });
        }

        #endregion

        #region Properties

        public ObservableCollection<ChatContent> Contents
        {
            get;
            private set;
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                base.SetProperty(ref _name, value);
            }
        }

        private string _content;
        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                base.SetProperty(ref _content, value);
            }
        }

        #endregion

        #region Commands

        public ICommand Append { get; private set; }

        #endregion

        #region Commands Executes

        public void AppendExecute()
        {
            var chatContent = new ChatContent
            {
                Name = this.Name,
                Content = this.Content
            };
            this.Contents.Add(chatContent);
        }

        #endregion
    }
}
