Use ComputerGames;

GO
CREate View PublishersV
as
SElect Publishers.id As ID, Publishers.name_ as Название, Localizers.name_ as Локализатор,
Publishers.date_foundation as ДатаОснования, Publishers.country as Страна FROM Publishers, Localizers
WHERE Publishers.localizer = Localizers.id