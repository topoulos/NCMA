CREATE proc SetComplete(@id INT, @numrows INT OUTPUT)
as
update membercerts set Completed = 1 where ID = @id
select @numrows = COUNT(*) from membercerts where Completed=1 and ID=@id