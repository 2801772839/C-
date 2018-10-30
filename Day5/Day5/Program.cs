using System;

namespace Day5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//C#变量
			//1.
			//两个int类型变量相加
			int a=1;
			int b =2;
			int c = a + b;
			Console.WriteLine (c);
			Console.WriteLine ("a+b=c_" + "c的结果为" + c);
			//两个int类型变量想乘
			a = 5;
			b = 6;
			c = a * b;
			Console.WriteLine (c);
			Console.WriteLine ("a*b=c_" + "c的结果为" + c);
			//两个int类型变量想减
			a=8;
			b=4;
			c=a-b;
			Console.WriteLine(c);
			Console.WriteLine ("a-b=c_" + "c的结果为" + c);
			//两个int类型变量想除
			a=188;
			b=32;
			c=a/b;
			Console.WriteLine(c);
			Console.WriteLine ("a/b=c_" + "c的结果为" + c);
			//2
			//两个float类型变量相加
			float d=3.1f;
			float e = 4.0f;
			float f = d + e;
			Console.WriteLine (f);
			Console.WriteLine ("a+b=c_" + "f的结果为" + f);
			//两个float类型变量相减
			d=35.6f;
			e=56.1f;
			f=d-e;
			Console.WriteLine(f);
			Console.WriteLine ("d-e=f_" + "f的结果为" + f);
			//两个float类型变量想乘
			d=54.3f;
			e = 4.0f;
			f = d * e;
			Console.WriteLine (f);
			Console.WriteLine ("a*b=c_" + "f的结果为" + f);
			//两个float类型变量相除
			d=78.6f;
			e=3.6f;
			f=d/e;
			Console.WriteLine(f);
			Console.WriteLine ("d/e=f_" + "f的结果为" + f);
			//3.
			//两个double类型变量相加
			double g=6.6;
			double h = 5.5;
			double j = g + h;
			Console.WriteLine (j);
			Console.WriteLine ("g+h=j" + "j的结果为" + j);
			//两个double类型变量想减
			g = 8.8;
			h = 5.3;
			j = g - h;
			Console.WriteLine (j);
			Console.WriteLine ("g-h=j" + "j的结果为" +j);
			//两个double类型变量相乘
			g = 9.45;
			h = 6.13;
			j = g * h;
			Console.WriteLine (j);
			Console.WriteLine ("g*h=j" + "j的结果为" +j);
			//两个double类型变量相除
			g = 6.14915;
			h = 5.46124;
			j = g / h;
			Console.WriteLine (j);
			Console.WriteLine ("g/h=j" + "j的结果为" +j);
			//4.
			//两个short类型变量相加
			short k=123;
			short n=456;
			short m = m + n;
			Console.WriteLine (m);
			Console.WriteLine ("k+n=m" + "m的结果为" +m);
			//两个short类型变量想减
			k=11;
			n= 12;
			m= k + n;
			Console.WriteLine (m);
			//两个short类型变量相乘
			k=127;
			n=167;
			m = m*n;
			Console.WriteLine (m);
			Console.WriteLine ("k*n=m" + "m的结果为" +m);
			//两个short类型变量相除
			k=143;
			n=156;
			m=m/n;
			Console.WriteLine (m);
			Console.WriteLine ("k/n=m" + "m的结果为" +m);
			//5.
			//两个long类型变量相加
			long o=88;
			long p=77;
			long q=o+p;
			Console.WriteLine (q);
			Console.WriteLine("o+p=q"+"q的结果为"+q);
			//两个long类型变量相减
			o=33;
			p=22;
			q =o-p;
			Console.WriteLine (q);
			Console.WriteLine("o-p=q"+"q的结果为"+q);
			//两个long类型变量相乘
			o=55;
			p=32;
			q=o*p;
			Console.WriteLine (q);
			Console.WriteLine("o*p=q"+"q的结果为"+q);
			//两个long类型变量相除
			o=45;
			p=31;
			q=o/p;
			Console.WriteLine (q);
			Console.WriteLine("o/p=q"+"q的结果为"+q);
			//6.
			//两个uint类型变量相加
			long r=44;
			long s=34;
			long t=r+s;
			Console.WriteLine (t);
			Console.WriteLine("r+s=t"+"t的结果为"+t);
			//两个uint类型变量相减
			r=48;
			s=39;
			t=r-s;
			Console.WriteLine (t);
			Console.WriteLine("r-s=t"+"t的结果为"+t);
			//两个uint类型变量相乘
			r=38;
			s=56;
			t=r-s;
			Console.WriteLine (t);
			Console.WriteLine("r*s=t"+"t的结果为"+t);
			//两个uint类型变量相除
			r=48;
			s=39;
			t=r-s;
			Console.WriteLine (t);
			Console.WriteLine("r/s=t"+"t的结果为"+t);
			//7.
			//两个ulong类型变量相加
			ulong u=65;
			ulong  v=54;
			ulong  w=u+v;
			Console.WriteLine (w);
			Console.WriteLine ("u+v=w" + "t的结果为" + w);
			//两个ulong类型变量相减
			u=56;
			v=65;
			w=u-v;
			Console.WriteLine (w);
			Console.Write ("u-v=w" + "t的结果为" + w);
			//两个ulong类型变量相乘
			u=15;
			v=32;
			w=u*v;
			Console.WriteLine (w);
			Console.Write ("u*v=w" + "t的结果为" + w);
			//两个ulong类型变量相除
			u=65;
			v=96;
			w=u/v;
			Console.WriteLine (w);
			Console.Write ("u/v=w" + "t的结果为" + w);
			//8.
			//两个ushort类型变量相加
			ushort x=64;
			ushort y=32;
			ushort z=x+y;
			Console.WriteLine (z);
			Console.WriteLine ("x+y=z"+"z的结果为"+z);
			//两个ushort类型变量相减
			x=21;
			y=26;
			z=x-y;
			Console.WriteLine (z);
			Console.WriteLine ("x-y=z"+"z的结果为"+z);
			//两个ushort类型变量相乘
			x=45;
			y=65;
			z=x*y;
			Console.WriteLine (z);
			Console.WriteLine ("x*y=z"+"z的结果为"+z);
			//两个ushort类型变量相除
			x=54;
			y=14;
			z=x/y;
			Console.WriteLine (z);
			Console.WriteLine ("x/y=z"+"z的结果为"+z);

		}
	}
}
