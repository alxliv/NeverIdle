### NeverIdle
**NeverIdle**
*Beginner project just to learn github.*

**Tiny C# program for Windows (7-10) that prevents screen lock/sleep kicking in when computer is idle**
Sometimes you do not want your computer to lock up or go to sleep when you are not actively
using it. Just run this program and your computer will stay 'awake' forever (in theory).

It works by calling kernel32 function:
`SetThreadExecutionState(ES_CONTINUOUS | ES_SYSTEM_REQUIRED | ES_DISPLAY_REQUIRED);`
Many thanks to: [how-to-prevent-windows-from-entering-idle-state](http://stackoverflow.com/questions/6302185/how-to-prevent-windows-from-entering-idle-state)

*Enjoy!*






