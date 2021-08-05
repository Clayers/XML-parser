# XML-parser #
### Консольное приложение, поиска файлов по расширению и парсинга текста XML, из файла. ###
------------------------------------------------------
###### Возможности: ######
* Поиск всех файлов в катологе по заданному расширению.(*.xml *.dtsx *.txt)
* Парсинг текста XML по заданным критериям: Тег,Атрибут.
------------------------------------------------------
###### В проекте используются ######
* С#
------------------------------------------------------
###### Настройки ######

  * Path = @"F:\test"
  * FileType = "*.xml"
  * Tag= "filename"
  * Attribute = "id"
###### XML для теста. ######
   
  <? xml version = "1.0" encoding = "utf-8" ?>
  < configuration >
      < Settings >
         < directory id = "backUpPath" value = "D:/BACKUPS/" ></ directory >
         < filename id = "feilname" value = "SameName" ></ filename >
         < period id = "period" value = "15" ></ period >
      </ Settings >
  </ configuration >
 
###### Предварительный просмотр ######
   ![Результат](https://sun9-46.userapi.com/impg/YirCUBwcNe0kIKDJ3TogNesnaXPi_6SmIbDAzQ/6E-dzQgHB2I.jpg?size=459x183&quality=96&sign=3bd0449839d64a07d1440095d927777f&type=album)
