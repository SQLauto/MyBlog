create trigger _vxer_get_ist_id
on articles for insert
as
select id from inserted

insert into articles(title,mainContent,typeId) values('test','test',2)