В данном репозитории находится пример кода использования F# в коде C#.
Подробнее можно прочитать в [Яедекс.Дзен](https://zen.yandex.ru/media/id/5efedd0b45fdbe03364b9a6c/ispolzovanie-preimuscestv-koda-f-v-kode-na-c-604513b258285736dd79bfc4)

Solution делится на 3 проекта: Temperature(F#),CSharpLib(C#), ConsoleApp2 (C#).
Temperature(F#),CSharpLib(C#) - библиотеки классов.
ConsoleApp2 (C#) - консольное приложение.
TargetFramework указан на net6.0. Его у Вас может не быть.
В корне репозитория находится файл ***platform.target*** , его можно открыть в блокноте. В проекте используется Microsoft.SDK, поэтому в этом
файле выставляйте необходимую Вам платформу. [Подробнее по TargetFramework.](https://docs.microsoft.com/en-us/dotnet/standard/frameworks)