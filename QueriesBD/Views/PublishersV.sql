Use ComputerGames;

GO
CREate View PublishersV
as
SElect Publishers.id As ID, Publishers.name_ as ��������, Localizers.name_ as �����������,
Publishers.date_foundation as �������������, Publishers.country as ������ FROM Publishers, Localizers
WHERE Publishers.localizer = Localizers.id