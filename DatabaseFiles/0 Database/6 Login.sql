--replace //loginname// and //password// from vault
--IMPORTANT:  create login in MASTER

create login //login// with password = '//password'

--IMPORTANT: switch to HeartyHearthDB
create user cpudev_user from login //loginname//

alter role db_datareader add member cpudev_user
alter role db_datawriter add member cpudev_user

