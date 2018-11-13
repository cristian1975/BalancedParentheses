Given a small piece of text with different parentheses of different types: (), {}, [],
determine if the parentheses in the text are in balance. If this is not the case, determine
where the error occurs (3 characters before and after the error). For example, the
following text: "this ( is [ a ) text ] where the parentheses are ) incorrect." is incorrect
because the bracket is not closed before the parenthesis is closed. The error is ".a.).te".
This is an example text:
( demo text ( [test] ( just a small ( text ( with all kind of { parentheses in {( different (
locations ) who ) then } also } with ) each other ) should ) match ) or ) not... )
It should, of course, work with any text. Write an application, in a language (if possible C#)
to analyze if a text is correct.