Alter table [dbo].[Hostel]  add constraint RoonLimit check (RoomNo <= 900);

create proc dbo.uspLimitedtohundred
as
begin
insert into [dbo].[Hostel] 
	values ('101', 3)
end;

exec dbo.uspLimitedtohundred
