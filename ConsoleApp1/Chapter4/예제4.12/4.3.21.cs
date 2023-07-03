/*4.3.2 모든 타입의 조상: System.Object*/

Computer computer = new Computer();
object obj1 = computer;
computer pc1 = obj1 as computer;

Notebook notebook = new Notebook();
object obj2 = notebook;
notebook pc2 = obj2 as notebook;