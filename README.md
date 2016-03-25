# ctc [![Build status](https://ci.appveyor.com/api/projects/status/q83vovk0864485u7?svg=true)](https://ci.appveyor.com/project/jquintus/ctc)

Cinnamon Toast Crunch reads from the stdin and creates Windows 10 notifications 

**Send one message**
```
echo Hello World | ctc 
```

**Send a message for every line in a file**
```
cat file.txt | ctc 
```

**Send a message for every line in your log with an error**
```
tail -f myLog | grep ERROR | ctc 
```
