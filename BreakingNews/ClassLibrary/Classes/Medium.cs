using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Classes
{
	public class Medium
	{
		public delegate void NewsDelegate(object obj, NewsEventArgs e);
		public event NewsDelegate EventBreakingNews;

		public void SendBreakingNews(string title, string content, DateTime date)
		{
			NewsEventArgs BreakingNews = new NewsEventArgs(title, content, date);
			if (EventBreakingNews == null)
			{
				Console.WriteLine("0 Subcribers. Sorry! :(");
				return;
			}
			EventBreakingNews(this, BreakingNews);
		}



	}

	public class NewsEventArgs : EventArgs
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public DateTime Date { get; set; }
		public NewsEventArgs(string title, string content, DateTime date)
		{
			this.Title = title;
			this.Content = content;
			this.Date = date;
		}

	}

}
