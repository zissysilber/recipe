--IMPORTANT:  create login in MASTER

create login appadmin with password = 'PASSword123$%^'
if @@SERVERNAME like '%SQLExpress'
begin
	alter login appadmin with Password = '8Northoak!'
end

--IMPORTANT: switch to HeartyHearthDB
create user appadmin_user from login appadmin

select @@SERVERNAME

