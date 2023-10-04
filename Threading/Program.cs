using Threading.models;

ThreadC thread1 = new("100 a 300", 100, 300);
ThreadC thread2 = new("301 a 500", 301, 500);
ThreadC thread3 = new("501 a 700", 501, 700);

Thread execUm = new(thread1.Run);
Thread execDois = new(thread2.Run);
Thread execTres = new(thread3.Run);

execUm.Start();
execDois.Start();
execTres.Start();