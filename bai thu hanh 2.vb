// bai 1
Class Stack
    {
        Private int top;
        Private int[] s;
        Public Stack()
        {
            top = -1;
            s = New int[20];
        }
        Public Stack(int n)
        {
            top = -1;
            s = New int[n];

        }
        Public bool Full()
        {
            Return top == s.Length - 1;
        }
        Public bool Empty()
        {
            Return top == -1;
        }
        Public void Push(int x)
        {
            If (Full()) Console.WriteLine("Stack day");
            Else s[++top] = x;
        }
        Public int Pop()
        {
            If (Empty()) Throw New Exception("Stack rong");
            Else
            {
                int x = s[top--];
                Return x;
            }
        }
    }
    Class Hexa
    {
        Private int n;
        Private Stack s;
        Public void NHAP()
        {

            Console.Write("Nhap so nguyen n=");
            n = int.Parse(Console.ReadLine());

        }
        Public void Chuyencoso()
        {
            s = New Stack();
            String st = "0123456789ABCDEF";
            While (n!= 0)
            {
                s.Push((int)st[n % 16]);
                n = n / 16;
            }
            While (!s.Empty())
                Console.Write((char)s.Pop());

        }

    }

    Class Program
    {
        Static void Main1(String[] args)
        {

            Hexa t = New Hexa();
            t.NHAP();
            t.Chuyencoso();

            Console.ReadKey();



        }
    }
}

//bai 2
 Class PS
    {
        Private int ts, ms;
        Public PS()
        {
            ts = 0; ms = 1;
        }
        Public PS(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }
        Public PS(PS t2)
        {
            this.ts = t2.ts;
            this.ms = t2.ms;
        }

        Public PS Tong(PS t2)
        {
            PS t = New PS();
            t.ts = this.ts * t2.ms + t2.ts * this.ms;
            t.ms = this.ms * t2.ms;
            Return t.Rutgon();
        }
        Public PS Hieu(PS t2)
        {
            PS t = New PS();
            t.ts = this.ts * t2.ms - t2.ts * this.ms;
            t.ms = this.ms * t2.ms;
            Return t;
        }
        Public PS Nhan(PS t2)
        {
            PS t = New PS();
            t.ts = this.ts * t2.ts;
            t.ms = this.ms * t2.ms;
            Return t.Rutgon();
        }
        Public PS CHIA(PS t2)
        {
            PS t = New PS();
            t.ts = this.ts * t2.ms;
            t.ms = this.ms * t2.ts;
            Return t.Rutgon();
        }
        Public Static bool Operator ==(PS t1, PS t2)
        {
            Return t1.ts * t2.ms == t2.ts * t1.ms;
        }
        Public Static bool Operator !=(PS t1, PS t2)
        {
            Return t1.ts * t2.ms!= t2.ts * t1.ms;
        }
        Public int UCLN(int ts, int ms)
        {
            ts = Math.Abs(ts); ms = Math.Abs(ms);
            While (ts!= ms)
            {
                If (ts > ms) ts = ts - ms;
                If (ts < ms) ms = ms - ts;
            }
            Return ts;
        }
        Public PS Rutgon()
        {
            int uc = UCLN(this.ts, this.ms);
            this.ts = this.ts / uc;
            this.ms = this.ms / uc;
            Return this;
        }
        Public void Hien()
        {
            If (ms == 1) Console.WriteLine("{0}", ts);
            ElseIf (ts == 0) Console.WriteLine("{0}", 0);
            Else Console.WriteLine("{0}/{1}", ts, ms);
        }
        Public Static bool Operator >(PS t1, PS t2)
        {
            Return t1.ts * t2.ms > t2.ts * t1.ms;
        }
        Public Static bool Operator <(PS t1, PS t2)
        {
            Return t1.ts * t2.ms < t2.ts * t1.ms;
        }



    }
    Class APP
    {
        Static void Main2()
        {
            PS t1 = New PS(4, 5);
            PS t2 = New PS(9, 10);
            Console.Write(" Tong 2 phan so la: ");
            PS t = t1.Tong(t2);
            t.Hien();
            Console.Write(" Hieu 2 phan so la: ");
            PS t3 = t1.Hieu(t2);
            t3.Hien();
            Console.Write(" Nhan 2 phan so bang: ");
            PS t4 = t1.Nhan(t2);
            t4.Hien();
            Console.Write(" chia 2 phan so bang: ");
            PS t5 = t1.CHIA(t2);
            t5.Hien();
            If (t1 == t2) Console.WriteLine("Hai phan so bang nhau");
            Else Console.WriteLine("Hai phan so khong bang nhau");
            If (t1 > t2) Console.WriteLine("t1>t2");
            Else Console.WriteLine("t1<=t2");
            Console.ReadKey();
        }
    }
}
//bai 3
Class Queue
    {
        Private int dau, cuoi;
        Private int[] q;
        Public Queue()
        {
            dau = cuoi = 0;
            q = New int[20];
        }
        Public Queue(int n)
        {
            dau = cuoi = 0;
            q = New int[n];

        }
        Public bool isFull()
        {
            Return cuoi >= q.Length - 1;
        }
        Public bool isEmpty()
        {
            Return dau == 0;
        }
        Public void Push(int x)
        {
            If (isFull()) Console.WriteLine("Stack day");
            Else
            {
                cuoi++;
                q[cuoi] = x;
            }
        }
        Public int Pop()
        {
            If (isEmpty()) Throw New Exception("Stack rong");
            Else
            {
                int x = q[dau];
                dau--;
                Return x;
            }
        }
    }
}

//bai 4
Class DATHUC
    {
        Private int n;
        Private int[] a;
        Public DATHUC()
        {
            n = 0; a = New int[0];
        }
        Public DATHUC(int n)
        {
            this.n = n;
            a = New int[n];
        }
        Public void Nhap()
        {
            For (int i = 0; i < n; i++)
            {
                Console.Write("Nhap a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        Public void Hien()
        {
            For (int i = 0; i < n; i++)
                Console.Write("{0}\n", a[i]);
            Console.WriteLine();
        }
        Public DATHUC Tong(DATHUC T2)
        {
            If (this.n == T2.n)
            {
                DATHUC t = New DATHUC(this.n);
                For (int i = 0; i < n; i++)

                    t.a[i] = this.a[i] + T2.a[i];
                Return t;
            }
            Else Return null;
        }
        Public DATHUC Hieu(DATHUC T2)
        {
            If (this.n == T2.n)
            {
                DATHUC t = New DATHUC(this.n);
                For (int i = 0; i < n; i++)

                    t.a[i] = this.a[i] - T2.a[i];
                Return t;
            }
            Else Return null;
        }

    }

// bai 5
Class Data
    {
        Private int day, month, year;
        Public Data(DateTime dt)
        {
            day = dt.Day;
            month = dt.Month;
            year = dt.Year;
        }
        Public void Hien()
        {
            Console.WriteLine("{0}/{1}/{2}", month, day, year);
        }