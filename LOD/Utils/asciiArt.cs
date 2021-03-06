using System;
using System.Collections.Generic;
using System.Text;

namespace LOD.Utils
{
    class AsciiArt
    {
        public string TitleArt { get; } =

@" /$$$$$$$$ /$$                       /$$                                                     /$$      
|__  $$__/| $$                      | $$                                                    | $$      
   | $$   | $$$$$$$   /$$$$$$       | $$        /$$$$$$   /$$$$$$   /$$$$$$  /$$$$$$$   /$$$$$$$      
   | $$   | $$__  $$ /$$__  $$      | $$       /$$__  $$ /$$__  $$ /$$__  $$| $$__  $$ /$$__  $$      
   | $$   | $$  \ $$| $$$$$$$$      | $$      | $$$$$$$$| $$  \ $$| $$$$$$$$| $$  \ $$| $$  | $$      
   | $$   | $$  | $$| $$_____/      | $$      | $$_____/| $$  | $$| $$_____/| $$  | $$| $$  | $$      
   | $$   | $$  | $$|  $$$$$$$      | $$$$$$$$|  $$$$$$$|  $$$$$$$|  $$$$$$$| $$  | $$|  $$$$$$$      
   |__/   |__/  |__/ \_______/      |________/ \_______/ \____  $$ \_______/|__/  |__/ \_______/      
                                                         /$$  \ $$                                    
                                                        |  $$$$$$/                                    
                                                         \______/                                     
            /$$$$$$        /$$$$$$$            /$$ /$$                                                
           /$$__  $$      | $$__  $$          | $$| $$                                                
  /$$$$$$ | $$  \__/      | $$  \ $$  /$$$$$$ | $$| $$  /$$$$$$  /$$$$$$$                             
 /$$__  $$| $$$$          | $$  | $$ |____  $$| $$| $$ /$$__  $$| $$__  $$                            
| $$  \ $$| $$_/          | $$  | $$  /$$$$$$$| $$| $$| $$$$$$$$| $$  \ $$                            
| $$  | $$| $$            | $$  | $$ /$$__  $$| $$| $$| $$_____/| $$  | $$                            
|  $$$$$$/| $$            | $$$$$$$/|  $$$$$$$| $$| $$|  $$$$$$$| $$  | $$                            
 \______/ |__/            |_______/  \_______/|__/|__/ \_______/|__/  |__/                            
                                                                                                      
                                                                                                      
                                                                                                     ";
        public string VictoryArt { get; } =

@"██╗   ██╗ ██████╗ ██╗   ██╗    ██╗    ██╗ ██████╗ ███╗   ██╗██╗
╚██╗ ██╔╝██╔═══██╗██║   ██║    ██║    ██║██╔═══██╗████╗  ██║██║
 ╚████╔╝ ██║   ██║██║   ██║    ██║ █╗ ██║██║   ██║██╔██╗ ██║██║
  ╚██╔╝  ██║   ██║██║   ██║    ██║███╗██║██║   ██║██║╚██╗██║╚═╝
   ██║   ╚██████╔╝╚██████╔╝    ╚███╔███╔╝╚██████╔╝██║ ╚████║██╗
   ╚═╝    ╚═════╝  ╚═════╝      ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═══╝╚═╝
                                                               ";

        public string GameoverArt { get; } =

@"  ▄████  ▄▄▄       ███▄ ▄███▓▓█████  ▒█████   ██▒   █▓▓█████  ██▀███  
 ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀ ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒
▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███   ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒
░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄ ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  
░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒
 ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░
  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░  ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░
░ ░   ░   ░   ▒   ░      ░      ░   ░ ░ ░ ▒       ░░     ░     ░░   ░ 
      ░       ░  ░       ░      ░  ░    ░ ░        ░     ░  ░   ░     
                                                  ░     ";

        public string Shia1 { get; } =
@" _____ _   _ _____  ___    _      ___________ _____ _____ _   _______ 
/  ___| | | |_   _|/ _ \  | |    |  ___| ___ \  ___|  _  | | | |  ___|
\ `--.| |_| | | | / /_\ \ | |    | |__ | |_/ / |__ | | | | | | | |_   
 `--. \  _  | | | |  _  | | |    |  __|| ___ \  __|| | | | | | |  _|  
/\__/ / | | |_| |_| | | | | |____| |___| |_/ / |___\ \_/ / |_| | |    
\____/\_| |_/\___/\_| |_/ \_____/\____/\____/\____/ \___/ \___/\_|    
                                                                    ";

        public string Shia2 { get; } =
@":'######::'##::::'##:'####::::'###:::::::'##:::::::'########:'########::'########::'#######::'##::::'##:'########:
'##... ##: ##:::: ##:. ##::::'## ##:::::: ##::::::: ##.....:: ##.... ##: ##.....::'##.... ##: ##:::: ##: ##.....::
 ##:::..:: ##:::: ##:: ##:::'##:. ##::::: ##::::::: ##::::::: ##:::: ##: ##::::::: ##:::: ##: ##:::: ##: ##:::::::
. ######:: #########:: ##::'##:::. ##:::: ##::::::: ######::: ########:: ######::: ##:::: ##: ##:::: ##: ######:::
:..... ##: ##.... ##:: ##:: #########:::: ##::::::: ##...:::: ##.... ##: ##...:::: ##:::: ##: ##:::: ##: ##...::::
'##::: ##: ##:::: ##:: ##:: ##.... ##:::: ##::::::: ##::::::: ##:::: ##: ##::::::: ##:::: ##: ##:::: ##: ##:::::::
. ######:: ##:::: ##:'####: ##:::: ##:::: ########: ########: ########:: ########:. #######::. #######:: ##:::::::
:......:::..:::::..::....::..:::::..:::::........::........::........:::........:::.......::::.......:::..::::::::";



        public string Shia3 { get; } =
 @"       ____  _   _ ___    _      _     _____ ____  _____ ___  _   _ _____ 
      / ___|| | | |_ _|  / \    | |   | ____| __ )| ____/ _ \| | | |  ___|
  ~~~ \___ \| |_| || |  / _ \   | |   |  _| |  _ \|  _|| | | | | | | |_   ~~~
       ___) |  _  || | / ___ \  | |___| |___| |_) | |__| |_| | |_| |  _|  
      |____/|_| |_|___/_/   \_\ |_____|_____|____/|_____\___/ \___/|_|    ";

        public string Shia4 { get; } =
@"███████ ██   ██ ██  █████      ██      ███████ ██████  ███████  ██████  ██    ██ ███████ 
██      ██   ██ ██ ██   ██     ██      ██      ██   ██ ██      ██    ██ ██    ██ ██      
███████ ███████ ██ ███████     ██      █████   ██████  █████   ██    ██ ██    ██ █████   
     ██ ██   ██ ██ ██   ██     ██      ██      ██   ██ ██      ██    ██ ██    ██ ██      
███████ ██   ██ ██ ██   ██     ███████ ███████ ██████  ███████  ██████   ██████  ██      ";

        public string Shia5 { get; } =
 @"*      ______ _________     __   _______  ________  __  ______
 * *  / __/ // /  _/ _ |   / /  / __/ _ )/ __/ __ \/ / / / __/  *
   * _\ \/ _  // // __ |  / /__/ _// _  / _// /_/ / /_/ / _/  * *
    /___/_//_/___/_/ |_| /____/___/____/___/\____/\____/_/    *
                                                        ";
        public string Shia6 { get; } =
@" _______ _     _ _____ _______             _______ ______  _______  _____  _     _ _______
 |______ |_____|   |   |_____|      |      |______ |_____] |______ |     | |     | |______
 ______| |     | __|__ |     |      |_____ |______ |_____] |______ |_____| |_____| |      
                                                                                         ";
        public string Shia7 { get; } =
@"███████╗██╗  ██╗██╗ █████╗     ██╗     ███████╗██████╗ ███████╗ ██████╗ ██╗   ██╗███████╗
██╔════╝██║  ██║██║██╔══██╗    ██║     ██╔════╝██╔══██╗██╔════╝██╔═══██╗██║   ██║██╔════╝
███████╗███████║██║███████║    ██║     █████╗  ██████╔╝█████╗  ██║   ██║██║   ██║█████╗  
╚════██║██╔══██║██║██╔══██║    ██║     ██╔══╝  ██╔══██╗██╔══╝  ██║   ██║██║   ██║██╔══╝  
███████║██║  ██║██║██║  ██║    ███████╗███████╗██████╔╝███████╗╚██████╔╝╚██████╔╝██║     
╚══════╝╚═╝  ╚═╝╚═╝╚═╝  ╚═╝    ╚══════╝╚══════╝╚═════╝ ╚══════╝ ╚═════╝  ╚═════╝ ╚═╝     ";
        public string Shia8 { get; } =
 @"  __      ___  _         ___ __   ___  _      ___ 
 (_ ` )_)  )  /_)    )   )_  )_)  )_  / ) / / )_  
.__) ( ( _(_ / /    (__ (__ /__) (__ (_/ (_/ (    ";

        public string ShiaSurprise { get; } =
@"    ::::::::  :::    ::: :::::::::::     :::           ::::::::  :::    ::: :::::::::  :::::::::  :::::::::  ::::::::::: ::::::::  :::::::::: 
    :+:    :+: :+:    :+:     :+:       :+: :+:        :+:    :+: :+:    :+: :+:    :+: :+:    :+: :+:    :+:     :+:    :+:    :+: :+:         
   +:+        +:+    +:+     +:+      +:+   +:+       +:+        +:+    +:+ +:+    +:+ +:+    +:+ +:+    +:+     +:+    +:+        +:+          
  +#++:++#++ +#++:++#++     +#+     +#++:++#++:      +#++:++#++ +#+    +:+ +#++:++#:  +#++:++#+  +#++:++#:      +#+    +#++:++#++ +#++:++#      
        +#+ +#+    +#+     +#+     +#+     +#+             +#+ +#+    +#+ +#+    +#+ +#+        +#+    +#+     +#+           +#+ +#+            
#+#    #+# #+#    #+#     #+#     #+#     #+#      #+#    #+# #+#    #+# #+#    #+# #+#        #+#    #+#     #+#    #+#    #+# #+#             
########  ###    ### ########### ###     ###       ########   ########  ###    ### ###        ###    ### ########### ########  ##########       ";

        public string Confetti { get; } =
@"               *    *
   *         '       *       .  *   '     .           * *
                                                               '
       *                *'          *          *        '
   .           *               |               /
               '.         |    |      '       |   '     *
                 \*        \   \             /
       '          \     '* |    |  *        |*                *  *
            *      `.       \   |     *     /    *      '
  .                  \      |   \          /               *
     *'  *     '      \      \   '.       |
        -._            `                  /         *
  ' '      ``._   *                           '          .      '
   *           *\*          * .   .      *
*  '        *    `-._                       .         _..:='        *
             .  '      *       *    *   .       _.:--'
          *           .     .     *         .-'         *
   .               '             . '   *           *         .
  *       ___.-=--..-._     *                '               '
                                  *       *
                *        _.'  .'       `.        '  *             *
     *              *_.-'   .'            `.               *
                   .'                       `._             *  '
   '       '                        .       .  `.     .
       .                      *                  `
               *        '             '                          .
     .                          *        .           *  *
             *        .                                    '";

        public string Exposition { get; } = "A bright flash of light blinds your eyes as the world around you dissolves. After a moment of disorientation you find yourself standing in a small courtyard atop a calm mountain. What happened? How did you get here? How do you get home? The answers are hidden in the world around you.";

        public string Map { get; } =
        @"
                   +-------------+    +-------------+
                   |             |    |             |
                   |             |    |             |
                   |   Tunnel    |    |   Temple    |
                   |             |    |    Door     |
                   |             |    |             |
                   +------^------+    +------^------+
                          |                  |
                   +------+------+    +------+------+                       +-------------+
                   |             |    |             |                       |             |
                   |             |    |             |                       |             |
                   |     Icy     |    |   Temple    |                       |    Dark     |
                   |    Ravine   |    |             |                       |    Woods    |
                   |             |    |             |                       |             |
                   +------^------+    +------^------+                       +------^------+
                          |                  |                                     |
+-------------+    +------+------+    +------+------+    +-------------+    +------+------+
|             |    |             |    |             |    |             |    |             |
|             |    |             |    |             |    |             |    |             |
|     Dark    <----+    Icy      <----+  Mountain   +---->   Forest    +---->   Forest    |
|    Castle   |    |   Tundra    |    |     Top     |    |             |    |   Village   |
|             |    |             |    |             |    |             |    |             |
+------+------+    +-------------+    +------+------+    +-------------+    +------+------+
       |                                     |                                     |
+------v------+                       +------v------+                       +------v------+
|             |                       |             |                       |             |
|             |                       |             |                       |             |
|   Skeleton  |                       |    Desert   |                       |   Forest    |
|     Room    |                       |             |                       |    Dojo     |
|             |                       |             |                       |             |
+------+------+                       +------+------+                       +-------------+
       |                                     |
+------v------+                       +------v------+    +-------------+
|             |                       |             |    |             |
|             |                       |             |    |             |
|   Throne    |                       |    Desert   +---->   Desert    |
|    Room     |                       |     Wall    |    |   Village   |
|             |                       |             |    |             |
+-------------+                       +-------------+    +-------------+
        ";
    }
}
