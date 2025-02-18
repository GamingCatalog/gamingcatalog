# Каталог за Игри

"Каталог за Игри" е уеб приложение, което предоставя възможност за управление и разглеждане на база данни с видеоигри. Проектът е разработен с C# и ASP.NET и следва многопластова архитектура с ясно разделение между данни, бизнес логика и потребителски интерфейс.

## Съдържание

- [Общ преглед](#общ-преглед)
- [Функционалности](#функционалности)
- [Използвани технологии](#използвани-технологии)
- [Инсталация](#инсталация)
- [Използване](#използване)
- [Структура на проекта](#структура-на-проекта)
- [Изпълнение на тестове](#изпълнение-на-тестове)
- [Сътрудничество](#сътрудничество)
- [Лиценз](#лиценз)

## Общ преглед

"Каталог за Игри" предоставя интуитивна платформа за разглеждане на широк спектър от видеоигри. Приложението е разделено на няколко проекта, които покриват общи утилити, модели на данни, услуги и уеб интерфейс. Независимо дали сте разработчик, който желае да разшири функционалността, или потребител, търсещ актуална информация за игрите, този проект предлага надеждно решение.

## Функционалности

- **Преглед и търсене:** Лесна навигация през обширен списък с игри.
- **Подробна информация за игрите:** Достъп до детайлни описания и метаданни за всяка игра.
- **Чиста архитектура:** Ясно разделение на слоевете – данни, услуги и уеб презентация.
- **Отзивчив интерфейс:** Модерен уеб дизайн, изграден с HTML, CSS и JavaScript.

## Използвани технологии

- **Backend:** C#, ASP.NET (MVC/Core)
- **Frontend:** HTML, CSS, JavaScript
- **Тестване:** Unit тестове, намиращи се в проекта `GoodGameDatabase.UnitTests`
- **Управление на пакети:** 
  - .NET зависимости, управлявани чрез NuGet
  - Зависимости на фронтенд, управлявани чрез Node.js (`package.json` и `package-lock.json`)

## Инсталация

1. **Клониране на репозитория:**

   ```bash
   git clone https://github.com/GamingCatalog/gamingcatalog.git
   ```

2. **Отваряне на решението:**
   - Отворете файла `CSharp_Pathway_Final_Project.sln` във Visual Studio или предпочитаната от вас C# IDE.

3. **Възстановяване на зависимости:**
   - За .NET пакетите използвайте NuGet Package Manager във Visual Studio.
   - За Node пакетите (ако са необходими за инструменти на фронтенд), изпълнете:
     ```bash
     npm install
     ```

4. **Компилиране на проекта:**
   - Компилирайте решението във Visual Studio или през командния ред с:
     ```bash
     dotnet build
     ```

## Използване

- **Стартиране на приложението:**
  - Стартирайте приложението чрез Visual Studio (например чрез IIS Express или друг избран метод за хостване).
  - Отворете браузър и посетете URL адреса (обикновено `http://localhost:PORT`), за да достъпите "Каталог за Игри".

- **Изпълнение на тестове:**
  - Използвайте Test Explorer на Visual Studio или изпълнете следната команда в директорията `GoodGameDatabase.UnitTests`:
    ```bash
    dotnet test
    ```

## Структура на проекта

```
GamingCatalog/
├── GoodGameDatabase.Common/
├── GoodGameDatabase.Data/
├── GoodGameDatabase.Data.Model/
├── GoodGameDatabase.Services.Data/
├── GoodGameDatabase.UnitTests/
├── GoodGameDatabase.Web.Infrastructure/
├── GoodGameDatabase.Web.ViewModels/
├── GoodGameDatabase/
├── node_modules/
├── .gitignore
├── package.json
├── package-lock.json
└── CSharp_Pathway_Final_Project.sln
```

## Сътрудничество

Приемаме приноси! Ако имате предложения, поправки или нови функционалности, моля:

1. Fork-нете репозитория.
2. Създайте нов клон за вашата функционалност или поправка.
3. Подайте pull request с ясно описание на направените промени.

## Лиценз

Този проект е лицензиран под MIT License. За повече информация вижте файла [LICENSE](LICENSE).
```
