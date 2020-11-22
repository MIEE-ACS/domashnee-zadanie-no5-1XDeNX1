using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WpfApp11.SquereEqModel
{
	class Class1
	{
		public class SquereEquetion : INotifyPropertyChanged
		{
			public double a_;
			public double b_;
			public double c_;
			public string Roots_;
			virtual public double aX
			{
				get { return a_; }
				set
				{
					if (a_ == value)
						return;
					a_ = value;
					OnPropertyChanged("aX");
				}
			}
			virtual public double bX
			{
				get { return b_; }
				set
				{
					if (b_ == value)
						return;
					b_ = value;
					OnPropertyChanged("bX");
				}
			}
			virtual public double cX
			{
				get { return c_; }
				set
				{
					if (c_ == value)
						return;
					c_ = value;
					OnPropertyChanged("cX");
				}
			}

			virtual public string RootX
			{
				get
				{
					if(Math.Pow(b_, 2) - 4 * a_ * c_ > 0)
						Roots_ = Convert.ToString((Math.Sqrt(Math.Pow(b_, 2) - 4 * a_ * c_) - b_) / 2) + "; " + Convert.ToString((-Math.Sqrt(Math.Pow(b_, 2) - 4 * a_ * c_) - b_) / 2);
					if (Math.Pow(b_, 2) - 4 * a_ * c_ == 0)
						Roots_ = Convert.ToString((Math.Sqrt(Math.Pow(b_, 2) - 4 * a_ * c_) - b_) / 2) + ";";
					if (Math.Pow(b_, 2) - 4 * a_ * c_ < 0)
						Roots_ = "Корней нет";
					return Roots_;
				}
				set
				{
					if (Roots_ == value)
						return;
					Roots_ = value;
					OnPropertyChanged("RootsX");
				}
			}
			public override string ToString()
			{
				return $"A = {aX}, B = {bX}, C = {cX}, Корни: {RootX}";
			}
			public event PropertyChangedEventHandler PropertyChanged;
			protected virtual void OnPropertyChanged(string propertyName = "")
			{
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
