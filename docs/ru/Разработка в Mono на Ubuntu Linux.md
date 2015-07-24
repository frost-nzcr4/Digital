# Разработка в Mono на Ubuntu Linux

Проверено на:

    * Ubuntu 15.04.1, Mono 3.2.8.0 и XBuild 12.0.
    * Ubuntu 14.10, Mono 4.0.2.5 и XBuild 12.0.

## Установка

```ShellSession
git clone https://github.com/SinTiger/Digital.git
cd Digital
```

## Необходимые пакеты

```ShellSession
sudo apt-get install mono-complete
```

## Компиляция


```ShellSession
cd Survival_on_island
xbuild Survival_on_island/Survival_on_island.csproj
```

## Запуск

```ShellSession
mono Survival_on_island/bin/Debug/Survival_on_island.exe
```

## IDE

На примере MonoDevelop 5.5 и 5.9.4.

Если в вашем дистрибутиве недоступна эта версия, то установите последнюю
по инструкции http://www.mono-project.com/docs/getting-started/install/linux/.

```ShellSession
sudo apt-get install exuberant-ctags monodevelop monodevelop-database monodevelop-nunit monodevelop-versioncontrol
monodevelop Survival_on_island/Survival_on_island.csproj
```

или откройте проект через меню:

    File > Open > Survival_on_island/Survival_on_island.csproj

После первого открытия MonoDevelop начнёт скачивать и устанавливать пакеты, указанные в зависимостях проекта.
Это займёт какое-то время. Если у вас не устанавливаются пакеты из NuGet репозитория см. Приложение 1.

## Установка NuGet Command Line

Этот пакет необходим для скачивания других пакетов из консоли.

1. Откройте меню:

    Project > Add NuGet packages ("Add packages" в MonoDevelop версии < 5.9.4)

введите в поиск "packageid:NuGet.CommandLine" и установите пакет.

2. Добавьте доверенные серитификаты безопасности:

    mozroots --import --sync

3. Чтобы загрузить пакеты используйте:

    mono Survival_on_island/packages/NuGet.CommandLine.2.8.6/tools/NuGet.exe install [packageid] [-Version версия] -o Survival_on_island/packages/

Внимание:

    Существует небольшая проблема в NuGet для Linux: он игнорирует параметр "output directory" в файле nuget.config,
    необходимо использовать аргумент `-o папка` чтобы указать папку для сохранения пакетов.

Дополнительная информация по возможным ошибкам при установке доступна здесь http://headsigned.com/article/running-nuget-command-line-on-linux

## Приложение 1. Установка репозитория NuGet

### MonoDevelop версии 5 и выше

Проверьте наличие дополнения "NuGet package management":

    Tools > Add-in manager > Installed > IDE extensions

если его нет, то установите через:

    Tools > Add-in manager > Gallery > IDE extensions

### MonoDevelop версии 4 и ниже

Установите как сказано в инструкции https://github.com/mrward/monodevelop-nuget-addin
