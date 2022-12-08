# SOLID

SRP -> Single Responsibilty Principle
OCP -> Open Close Principle = Sınıflar gelişmeye açık lakin değişmeye kapalı olmalıdır.
LSP -> Liskov Substitution Principle
ISP -> Interface Segregation Principle
DIP -> Dependency Inversion Principle (Dependeny = Bağlılık)
### NOT
Concrete ve abstract diye iki folder olusturup ınterface ve abstract classları abstract clasaa eklemek diğer classları Concrete folderıne aklemek daha düzenli olacaktır.

## Project 1 - SRP  (Single Responsibilty Principle)
- Ornek - > PersonelOlusturucu adında bir class açtık ancak bu SRP'ye uygun bir şekilde olmadı
- Duzeltilmis Ornek -> Personel

## Project 2 - OCP (Open Close Principle)
- Ornek2
- Ornek2Duzeltilmiş(Open close prensibine göre)
- CoffeeExample
- DuzenlenmişUygunHali (Coffee örneğinin Open close prensibine göre)

## Project 3 - LSP (Liskov Substitution Principle)
- OrnekBad 
- OrnekBadDuzeltilmis (Liskov Substitution prensibine göre)
(Alan Hesaplayıcı örneği)

## Project 4 - ISP (Interface Segregation Principle)
- KusOrnegi  
- KusOrnegiDuzeltilmis (Interface Segregation prensibine göre)
(Kus türleri ile alakalı Interface Segregation prensibine uyan ve uymayan şekilde örneklendi.)

## Project 5 - DIP (Dependency Inversion Principle)
- Ornek (Köfte-Tavuk konusu)
- OrnekDuzenlenmis (Dependency Inversion prensibine göre)
- Loglama -> Dependency Inversion prensibine uygun şekilde tek ornek yapıldı.

## Project 6 - IOC_Sample (Inversion of control)
- **NOT:** Dependency Inversion Dependences injection yapmış oluyor.????
- Yapılan konuya/örneğe bu [linkten](https://www.tutorialsteacher.com/ioc) bakabilirsiniz.
- unity paketini kurduk
- Constructor bazlı injection

## Project 7 - IOC_SampleNETCore
- Console Application açıldı.
- Microsoft.Extensions.DependencyInjection paketini indirdik.NugGet'lardan 
- Bir önrek yapıldı.
