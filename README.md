![image](https://user-images.githubusercontent.com/23088305/39225217-073f7dc8-4819-11e8-86f8-bcfdbc395d10.png)

Tool to watch NHL games in High Definition    

Choose a date.    
Choose a game.    
Choose a stream.    
Enjoy!

![image](https://user-images.githubusercontent.com/23088305/39225241-269c99bc-4819-11e8-8f76-22e4d1f707ed.png)

## /_Index_
* [First use](#first-use)
  * [Requirements](#requirements)
  * [Message about the hosts file](#message-about-the-hosts-file) _v.1.3 and before_
  * [Is this app safe?](#is-this-app-safe)
 * [User interface](#user-interface)
   * [Games](#games)
      * [Navigation bar](#navigation-bar)
      * [Game panel](#game-panel)
   * [Settings](#settings)
     * [Customize game panels](#customize-game-panels)
     * [Stream Quality](#stream-quality)
     * [Rewind and Replay](#rewind-and-replay)
     * [Content Delivery Network (CDN)](#content-delivery-network-cdn)
     * [Server's Hostname](#servers-hostname)
     * [Server Hosts Entry](#server-hosts-entry) _v.1.3 and before_
     * [Players](#players)
     * [Streamer](#streamer)
     * [Language](#language)
     * [Dark Theme](#dark-theme)
     * [Arguments](#arguments)
     * [Ad Detection](#ad-detection)
   * [Console](#console)
* [Support](#support)
* [Chromecast](#chromecast)
  * [VLC 3.0](#vlc-30)
  * [Google Chrome](#google-chrome)
* [Phones and TVs](#phones-and-tvs)
* [Contribute](#contribute)
* [Donation](#donation)
* [Download](#download)

___

# /_First use_
## //_Requirements_
NHLGames is an app built on .NET Framework 4.5. So, it's only available on Windows, Windows XP and Vista are not supported, and it works on any CPU (x86/x64). If you run NHLGames on Windows 7 you will probably need to install :
- [.NET Framework 4.5](https://www.microsoft.com/en-ca/download/details.aspx?id=30653)

You will also need, if you downloaded the simplified version instead of the complete version in the Releases page:
- A supported [media player](#players)
- A supported [streamer](#streamer)

## //_Message about the hosts file_
--- _v.1.3 and before_ ---    
First time you start NHLGames it will ask if you wish to view the Hosts file. That means the app has changed a system file to let you use NHLGames without issues by adding a line like this one `XXX.XXX.XXX.XXX www.hosting.site.com` at the end of it. If you want to view the changes, then click Yes and you will have to select Notepad to view the file. If NHLGames did not succesfully changed this file, see the [Server Hosts Entry](#server-hosts-entry) section.

## //_Is this app safe?_
Yes, it is. However, some anti-virus or anti-malware won't agree because we edit your hosts file in Windows/System32/drivers/etc/, a file used to redirect nhl.com to another ip. We do that, to make sure the app will get stream links for games that are available. But don't worry, this server only responds in plain text and won't hurt your pc. If you don't trust us, find out by yourself by looking at our code.

# /_User interface_
Everytime you launch NHLGames it will search for today's games. 

## //_Games_
### ///_Navigation bar_
If you want to watch past games, use the calendar or use the arrows to navigate through the days.
![image](https://user-images.githubusercontent.com/23088305/32304708-b0bf16f2-bf47-11e7-99f7-51c9dcb2382f.png)
Use the refresh button (at the right) to refresh the current day games.

### ///_Game panel_
Game panels can be customize to show or hide infos, it can be set in settings. Only today's games will show with a blue frame, like the one below :

![image](https://user-images.githubusercontent.com/23088305/38785698-79bfe94e-40f0-11e8-85c6-505119cdd0c1.png)

Today's games are blue:
- Upcoming games : blue frame
- Pregame games: blue frame and blue top banner
- Live games : blue frame, blue top banner and live icon (red)

Every others games, past or scheduled, are grey:
- Past games: grey frame with a grey top banner
- Scheduled games: grey frame

## //_Settings_
### ///_Customize Game panels_
NHLGames gives you some options to change how a game panel will appear.

*Final Scores* : If on, it shows final score of all past games between the teams logo.    
*Live Scores* : If on, it shows live score of all games in progress between the teams logo.    
*Series Record* : If on, it shows serie records under the game status, like: Game 4 Tied 2-2  
*Teams city abbreviation*: If on, it shows team city abbreviation under the team logo, like: MTL   
*Live games first*: If on, games list will be ordered by live games first

### ///_Stream Quality_
The selected value will defined which quality will be sent to your media player, from the worst to the best quality. Selecting the highest quality also means bigger files to download :
- Excellent: 720p or better at 60fps ~2.50 Gb/hr
- Superb: 720p ~1.80 Gb/hr
- Great: 540p ~1.30 Gb/hr
- Good: 504p ~950 Mb/hr
- Normal: 360p ~700 Mb/hr
- Low: 228p ~500 Mb/hr
- Mobile: 224p or worst ~300/hr

### ///_Rewind and Replay_
The Rewind/Replay feature is only available for Live games only. If you see a blue game panel with a ![image](https://user-images.githubusercontent.com/23088305/38781081-37d9d68a-40ae-11e8-8c37-50388470b299.png) icon in the left corner that means you will have access to the Replay or Rewind feature. To use the feature, you have click on the icon (top-left corner of the game panel), and click on a stream to start watching.
- ![image](https://user-images.githubusercontent.com/23088305/38781195-9eecf626-40af-11e8-85fb-857c7d50d385.png) Rewind: click it once.
- ![image](https://user-images.githubusercontent.com/23088305/38781187-9418e818-40af-11e8-86df-d8025473574c.png) Replay: click it twice. 
- ![image](https://user-images.githubusercontent.com/23088305/38781081-37d9d68a-40ae-11e8-8c37-50388470b299.png) Live (default): Click it three times to set it back to Live. 

![image](https://user-images.githubusercontent.com/23088305/35660550-a8ccfe3e-06da-11e8-974c-141f6d3b3d31.gif)

> *WARNING: If you want to use the Rewind/Replay feature, but you don't click on the *Live* icon before starting a stream, you will still be in live mode !*

If you use the rewind or replay feature and you want to change the default behaviour, you can set your preferences here.
- Live Rewind: If Rewind is enabled , it will use the value to set the stream x minutes behind the live stream.
- Live Replay: If Replay is enabled , it will start the stream from the selected value.

> *NOTE: If you use the rewind slider in settings, but you set it before game time and the stream has no data at this time, it might start from live.*

### ///_Content Delivery Network (CDN)_
NHLGames uses by default Akamai CDN, but Level 3 can be activated by turn on the alternate network in settings.

Default: Akamai
> Akamai is one of the oldest CDNs and generally considered to be the largest global CDN. They have 'servers everywhere' and a wide range of products and services. The company is actively involved in Let's Encrypt and is pushing HTTP/2 adoption.

Alternate: Level 3
> Level 3 owns and operates a global Tier-1 network and - logically - their CDN runs on top of it. It has POPs on all continents and their product focus is on video and large object delivery. Level 3 CDN is part of the Google Cloud CDN Interconnect.

### ///_Server's Hostname_
This drop down list shows all NHLGames server hostname, so if you can't play games, try another hostname.

### ///_Server Hosts Entry_
--- _v.1.3 and before_ ---    
If the selected hostname (above) can be resolved by your network, it will get and save the related IP address in the Windows Hosts file. 

To test your Hosts file, go to Settings and use the *Hosts File* drop down list (like shown below):
![image](https://user-images.githubusercontent.com/23088305/38848870-64037f66-41d7-11e8-9873-f26c3fb3085a.png)
> Select ***Test if the NHL.tv authentication bypass works*** and click on GO.    
It should tells you if everything is fine.

If NHLGames is not set properly, try the following options:
> Right click on NHLGames.exe and select *Run as an administrator*.

In settings, use the *Hosts file* drop down list:
> Select ***Add the NHL.tv authentication bypass line to Hosts file***

If it does not work, try this other host file action:  
> Select ***Copy to clipboard the authentication bypass line***, click on GO  
> Select ***View Hosts file content in Notepad***, click on GO  

If it does not open, try this other host file action:
> Select ***Open Hosts file location*** or go to *C:\Windows\System32\Drivers\etc*. 
> Right click on **hosts** file and select Notepad as the editor.   

Go at the end of the file:  
> Press *CTRL+V* (or right click and click on Paste), our server redirection should be added.   

Now, save the hosts file:   
> Go to File > Save as, *CTRL+S*.  
On the save file dialog pops. Make sure: 
> File name is: `hosts`, not hosts.txt    
> File type is: `All Files (*.*)`, not Documents (\*.txt)  

Note: If you need to remove NHLGames entry, go back into the Hosts file drop down list in Settings and select *Remove the NHL.tv authentication bypass line from Hosts file* or *View Hosts file content in Notepad* and remove our entry.

### ///_Players_
NHLGames supports up to 3 media players:     
- [MPV](https://mpv.io/installation/) : a simple and powerful cross-platform media player    
- [VLC](https://www.videolan.org/vlc/index.html) : a strong and popular cross-platform multimedia player     
- [MPC](https://mpc-hc.org/downloads/) : a light-weight media player

If you don't have or want VLC/MPC players, use our default media player to watch games. Make sure you select MPV as the default player.

If you had previously installed VLC or MPC, NHLGames should find it automatically if you installed it in the default folder Program Files, otherwise you will have to browse ![image](https://cloud.githubusercontent.com/assets/23088305/25557239/b99ec37a-2cdb-11e7-8c27-d8b563128e8d.png) your computer and get the path to the EXE file. 

If you don't have one of these players installed and you want to install it, use the links on the right to download it.

### ///_Streamer_
A streamer is not a media player, it's an application that NHLGames use to get the stream from Internet and parse it to your media player. The default streamer that NHLGames provided can be found in the **Complete** zip, the **Simplified** does not have any. If you use the Complete package, just don't move the provided streamer and media player out of NHLGames folder, otherwise you will to specified another streamer to be able to stream a game.       
- [LiveStreamer](http://docs.livestreamer.io/install.html) : a command-line tool that extracts and pipes streams into a media player    
- [StreamLink](https://streamlink.github.io/install.html) : the same based command-line tool with many more plugins 

If you can't play any stream, you might need to install one of these streamer (the portable version might not work for everyone), follow the link above (click on the streamer you want), download the installer and set the path in NHLGames settings

If your antivirus or Windows Defender removes the streamer, try to install another version (e.g.: 1.0.7 instead of 1.0.8).

If you find one that works great for you, keep it, you will just have to change the path in settings when a new update of NHLGames will come out.

### ///_Dark Theme_
Renders NHLGames with dark tones. An application restarts is needed for changes to take effect.

### ///_Language_
NHLGames supports two languages: English and French.
More can be added, but we are waiting for contributions.

Contribute:
> If you want to contribute. Translate the file `NHLGames/NHLGames/English.resx`. It can be modified in Visual Studio, remove any lines tagged as Console lines (these are not translated), rename the file and open a Pull Request.

### ///_Arguments_
If you wish to customise the way your player or the streamer opens, turn on one of these options and add your arguments:
- Player args : If you want to add more arguments (commands) to be sent to your media player with the default args that NHLGames send.
- Streamer args : If you want to add more arguments (commands) to be sent to streamlink with the default args that NHLGames send.

### ///_Ad Detection_
NHLGames doesn't use any Ad Detection by default, but you can activate it and select the app you want to use during commercials. If you don't use any, it's better if you keept the Ad Detection disabled. 

Ad detection supports these applications:
- Spotify Windows / Other music player: If you want to play music during ads.
   - Force to start: It will open Spotify when you start NHLGames
   - Always play next song: It won't pause Spotify when the ad ends, but skip to the next song.
   - (Experimental) Try with the detected media player: If you do not have Spotify running, but another (like Windows Media Player or iTunes), it will play/pause this player instead, by simulating the media hotkey [Play/Pause] on the keyboard
- OBS Scene Changer : If you want to switch between windows when an ad hits.
   - Ad ending hotkey: Set the same hotkey that the one in OBS to display the window that the game is on.
   - Ad starting hotkey: Set the same hotkey that you use in OBS to display the window when a commercial plays.

## //_Console_
Go to this tab to see everything that NHLGames does. Also, any error or warning will show up here.

# /_Support_
Having an issue with NHLGames? Head to our [Wiki](https://github.com/NHLGames/NHLGames/wiki) to find a fix. Look at the side bar, on the right, to navigate between known issues. If you can't find it, feel free to open an [issue](https://github.com/NHLGames/NHLGames/issues).

# /_Chromecast_
NHLGames doesn't support Chromecast, but VLC 3.0 player and Google Chrome does. Follow these steps if you want to play the game on your TV.

## //_VLC 3.0_
![image](https://user-images.githubusercontent.com/23088305/37436787-15ef5fe2-27c0-11e8-8a47-b0a25b40a598.png)

## //_Google Chrome_
![image](https://cloud.githubusercontent.com/assets/23088305/25557771/3570cf2a-2ce6-11e7-980a-b605b93c66dc.png)

3. Select a pc monitor you want to share. Make sure audio share is checked.

<img src="https://cloud.githubusercontent.com/assets/23088305/25556591/3145542a-2ccd-11e7-8ba4-d4947e2bb84f.png" width="460"/>

4. Use NHLGames to get a stream, once the game plays, move the media player window to the right monitor and enjoy the show.

<img src="https://cloud.githubusercontent.com/assets/23088305/25556617/a6caab1e-2ccd-11e7-89d3-c9177a997ed1.png" width="300"/>

# /_Phones and TVs_
You can redirect the stream over the Internet by using VLC player output and host it.   
Open NHLGames, go to settings, select VLC as your default and turn on player args.    
Type `--sout=#http{mux=ts,dst=:8080/stream}`.   
Click on a stream, VLC should open after accepting new configs to your firewall.   
Go on your phone and use a player such as *MPV Mobile App* to open the link `ip:8080/stream` replace `ip` by your external ip (internet/WAN) (google `my ip`) or by your internal ip (local/LAN) (cmd.exe `ipconfig`)

# /_Contribute_
NHLGames is coded in VB.NET using Visual Studio and .Net Framework 4.5. If you want to contribute : [Follow the guidelines](CONTRIBUTING.md)

Thanks to our [contributors](https://github.com/NHLGames/NHLGames/graphs/contributors)

# /_Donation_

[Donate via Paypal](https://www.donation-tracker.de/donate/kturris)    
Donate via Bitcoin: `17uSfctCE4n5uLAHqZQEozqEiLafSaUgQL`

# /_Download_

### Windows: [Lastest release](https://github.com/NHLGames/NHLGames/releases)
