# Разработка в Mono на Ubuntu Linux

Проверено на Ubuntu 15.04.1, Mono 3.2.8.0 и XBuild 12.0.

## Установка

```ShellSession
git clone https://github.com/SinTiger/Digital.git
```

## Необходимые пакеты

```ShellSession
sudo apt-get install mono-complete
```

## Компиляция


```ShellSession
cd Survival_on_island
xbuild Survival_on_island.csproj
```

## Запуск

```ShellSession
mono bin/Debug/Survival_on_island.exe
```
