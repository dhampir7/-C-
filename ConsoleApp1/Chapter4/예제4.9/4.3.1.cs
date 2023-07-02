/*4.3.1 형변환*/

Notebook noteBook = new Notebook();

Computer pc1 = noteBook;    // 암시적 형변환 가능
pc1.Boot();
pc1.Shutdown();