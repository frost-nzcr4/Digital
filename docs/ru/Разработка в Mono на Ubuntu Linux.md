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
Это займёт какое-то время.
