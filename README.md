# TESTDOMEEXAMSCSHARP
TESTDOMEEXAMSCSHARP

https://www.testdome.com/d/c-sharp-interview-questions/18
https://www.testdome.com/questions/original/18996




SQL UNION DISTINCT <br/>
select distinct name from (select name from dogs union all select name from cats);<br/>


<br/>
 select userId, avg(duration) from sessions group by userId having count(*) > 1;
