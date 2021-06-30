![image](https://user-images.githubusercontent.com/23088305/39225217-073f7dc8-4819-11e8-86f8-bcfdbc395d10.png)

Tool to watch NHL games streams in High Definition

Choose a date.  
Choose a game.  
Choose a stream.  
Enjoy!

![image](https://user-images.githubusercontent.com/23088305/123110157-d3509580-d409-11eb-9527-5df8bd888807.png)

## _Index_

- [First use](#first-use)
  - [Requirements](#requirements)
  - [Is this app safe?](#is-this-app-safe)
- [User interface](#user-interface)
  - [Games](#games)
    - [Navigation bar](#navigation-bar)
    - [Game panel](#game-panel)
  - [Standings](#standings)
  - [Settings](#settings)
    - [Customize game panels](#customize-game-panels)
    - [Stream Quality](#stream-quality)
    - [Rewind and Replay](#rewind-and-replay)
    - [Content Delivery Network (CDN)](#content-delivery-network-cdn)
    - [Server's Hostname](#servers-hostname)
    - [Proxy Port](#proxy-port)
    - [Players](#players)
    - [Streamer](#streamer)
    - [Language](#language)
    - [Dark Theme](#dark-theme)
    - [Arguments](#arguments)
    - [Ad Detection](#ad-detection)
  - [Console](#console)
- [Support](#support)
- [Chromecast](#chromecast)
  - [VLC 3.0](#vlc-30)
  - [Google Chrome](#google-chrome)
- [Phones and TVs](#phones-and-tvs)
- [Contribute](#contribute)
- [Donation](#donation)
- [Download](#download)

---

# _First use_

## _Requirements_

NHLGames is an app built on .NET Framework 4.5. It's only available on Windows (Windows XP, Vista are not supported). Any CPU architecture is supported (x86/x64).

If you run NHLGames on Windows 7 you will probably need to install:

- [.NET Framework 4.5](https://www.microsoft.com/en-ca/download/details.aspx?id=30653)

If you downloaded the simplified version instead of the complete version in the Releases page, you'll need:

- A supported [media player](#players)
- A supported [streamer](#streamer)

## _Is this app safe?_

Yes, it is. The server only responds in plain text and won't harm your PC. You can verify yourself by inspecting the code.

# _User interface_

Everytime you launch NHLGames it will search for today's games.

## _Games_

### _Navigation bar_

If you want to watch past games, use the calendar or use the arrows to navigate through the days.
![image](https://user-images.githubusercontent.com/23088305/32304708-b0bf16f2-bf47-11e7-99f7-51c9dcb2382f.png)
Use the refresh button (right side) to refresh the current day's games.

### _Game panel_

Game panels will have a different frame color based on their game status (scheduled, pregame, live, ended).

Games broadcasting will be shown with a blue border:

![image](https://user-images.githubusercontent.com/23088305/52686505-fd314d80-2f1b-11e9-83a7-17bf80997cc8.png)

Other games (ended or scheduled) are grey:

![image](https://user-images.githubusercontent.com/23088305/52686420-99a72000-2f1b-11e9-93a4-5df0f85c6a1d.png)
![image](https://user-images.githubusercontent.com/23088305/52686434-b5aac180-2f1b-11e9-9eaa-abe31e889902.png)

Features on the panel:

- Watch recap by clicking on the play icon on the top-right corner (when available)
- Watch a stream by clicking on a network logo or a camera (hover on it to get some more info)
- Rewind a live stream: see [_Rewind and Replay_](#rewind-and-replay) section.

Game panels can be customized to show or hide information. It can be changed in the settings menu.

## _Standings_

It will show League, Conference, Division or Wild card standings for any season. You can also display the league standing for all teams in Games tab by turning ON the option **Standing rank** in Settings tab.

## _Settings_

### _Customize Game panels_

NHLGames gives you options to change how a game panel will appear.

| Option                    | Required game statuses to work | Default value |
| :------------------------ | :----------------------------- | :-----------: |
| Order by live games first | Today's games                  |     `ON`      |
| Live remaining time       | Live games                     |     `ON`      |
| Live scores               | Live games                     |     `OFF`     |
| Series record             | Live and past series games     |     `ON`      |
| Teams city abbreviation   | Upcoming, live and past games  |     `OFF`     |
| Final scores              | Past games                     |     `OFF`     |
| Standing rank (League)    | All                            |     `OFF`     |

### _Stream Quality_

The selected value will define which video quality will be sent to your media player, from the worst to the best quality. Selecting the highest quality also means larger files to download :

| Name      | Resolution              | Data usage  |
| :-------- | :---------------------- | :---------: |
| Excellent | 720p at 60fps (or best) | ~ 2.5 Gb/hr |
| Superb    | 720p                    | ~ 1.8 Gb/hr |
| Great     | 540p                    | ~ 1.3 Gb/hr |
| Normal    | 360p                    | ~ 0.7 Gb/hr |
| Low       | 228p                    | ~ 0.5 Gb/hr |
| Mobile    | 224p (or worst)         | ~ 0.3 Gb/hr |

### _Rewind and Replay_

The Rewind/Replay feature is only available for Live games only. If you see a blue game panel with a ![image](https://user-images.githubusercontent.com/23088305/38781081-37d9d68a-40ae-11e8-8c37-50388470b299.png) icon in the left corner that means you will have access to the Replay or Rewind feature. To use the feature, you have click on the icon (top-left corner of the game panel), and click on a stream to start watching.

- ![image](https://user-images.githubusercontent.com/23088305/38781195-9eecf626-40af-11e8-85fb-857c7d50d385.png) Rewind: click it once.
- ![image](https://user-images.githubusercontent.com/23088305/38781187-9418e818-40af-11e8-86df-d8025473574c.png) Replay: click it twice.
- ![image](https://user-images.githubusercontent.com/23088305/38781081-37d9d68a-40ae-11e8-8c37-50388470b299.png) Live (default): Click it three times to set it back to Live.

![image](https://user-images.githubusercontent.com/23088305/35660550-a8ccfe3e-06da-11e8-974c-141f6d3b3d31.gif)

> *WARNING: If you want to use the Rewind/Replay feature, but you don't click on the *Live* icon before starting a stream, you will still be in live mode !*

If you use the rewind or replay feature and you want to change the default behaviour, you can set your preferences here.

#### Live Replay

If Replay is selected, it will start the stream from the selected value

- When the game starts (drops the puck) - _7:10PM for a game scheduled at 7PM_
- When the event starts (game time) - _7:00PM for a game scheduled at 7PM_
- At the beginning of the stream - _Around 6:30PM (pregame) for a game starting at 7PM_

#### Live Rewind

If Rewind is selected, it will use the slider value to set the stream behind the live stream.

![image](https://user-images.githubusercontent.com/23088305/52688428-76cd3980-2f24-11e9-944c-f1990ad7bb6a.png)

> _NOTE: If you use the rewind slider in settings, but you set it before game time and the stream has no data at this time, it might start from live._

### _Content Delivery Network (CDN)_

NHLGames uses by default Akamai CDN, but Level 3 can be activated by turn on the alternate network in settings.

Default: Akamai

> Akamai is one of the oldest CDNs and is generally considered to be the largest global CDN. They have 'servers everywhere' and a wide range of products and services. The company is actively involved in Let's Encrypt and is pushing HTTP/2 adoption.

Alternate: Level 3

> Level 3 owns and operates a global Tier-1 network and their CDN runs on top of it. It has POPs on all continents and their product focus is on video and large object delivery. Level 3 CDN is part of the Google Cloud CDN Interconnect.

### _Server's Hostname_

This drop down list shows all NHLGames server hostnames. If you can't play games, try another hostname.

### _Proxy Port_

Use the slider to change the proxy port when starting NHLGames.

Remember that if you close NHLGames while watching a stream, it will close the proxy as well and it will kill the stream. Just minimize NHLGames instead while playing.

### _Players_

NHLGames supports 3 media players:

- [MPV](https://mpv.io/installation/) : a simple and powerful cross-platform media player
- [VLC](https://www.videolan.org/vlc/index.html) : a strong and popular cross-platform multimedia player
- [MPC](https://mpc-hc.org/downloads/) : a light-weight media player

If you don't have or want VLC/MPC players, use the default media player to watch games. Make sure you select MPV as the default player.

If you had previously installed VLC or MPC, NHLGames should find it automatically if you installed it in Program Files. Otherwise you will have to browse ![image](https://cloud.githubusercontent.com/assets/23088305/25557239/b99ec37a-2cdb-11e7-8c27-d8b563128e8d.png) your computer and get the path to the .EXE file.

If you don't have one of these players installed, use the links on the right to download it.

### _Streamer_

A streamer is not a media player. It's an application that NHLGames uses to get the stream from the Internet and parse it to your media player. The default streamer that NHLGames provided can be found in the **Complete** zip. The **Simplified** .zip file does not have any. If you use the Complete package, don't move the provided streamer and media player out of the NHLGames folder. Otherwise, you will have to speciy another streamer to be able to stream a game.

- [StreamLink](https://streamlink.github.io/install.html) : recommanded command-line tool that extracts and pipes streams into a media player
- [Livestreamer](https://docs.livestreamer.io/install.html) : old and deprecated tiny command-line tool that extracts and pipes streams into a media player. It may takes 60 secs to open a stream.

Follow the link above, download the installer and set the path in NHLGames settings.

### _Dark Theme_

Renders NHLGames with dark tones. An application restarts is needed for changes to take effect.

### _Language_

NHLGames supports two languages: English and French.
More can be added, but we are waiting for contributions.

Contribute:

> If you want to contribute. Translate the file `NHLGames/NHLGames/English.resx`. It can be modified in Visual Studio, remove any lines tagged as Console lines (these are not translated), rename the file and open a Pull Request.

### _Arguments_

If you wish to customise the way your player or the streamer opens, turn on one of these options and add your arguments:

- Player args : If you want to add more arguments (commands) to be sent to your media player with the default args that NHLGames send.
- Streamer args : If you want to add more arguments (commands) to be sent to streamlink with the default args that NHLGames send.

### _Ad Detection_

NHLGames doesn't use any Ad Detection by default, but you can activate it and select the app you want to use during commercials. If you don't use any, it's better if you keept the Ad Detection disabled.

Ad detection supports these applications:

- Spotify Windows / Other music player: If you want to play music during ads.
  - Force to start: It will open Spotify when you start NHLGames
  - Always play next song: It won't pause Spotify when the ad ends, but skip to the next song.
  - (Experimental) Try with the detected media player: If you do not have Spotify running, but another (like Windows Media Player or iTunes), it will play/pause this player instead, by simulating the media hotkey [Play/Pause] on the keyboard
  - Media control delay: By default 100ms, but can be increased if Spotify does not play or pause at the right time, 1000ms = 1 second btw.
- OBS Scene Changer : If you want to switch between windows when an ad hits.
  - Ad ending hotkey: Set the same hotkey that the one in OBS to display the window that the game is on.
  - Ad starting hotkey: Set the same hotkey that you use in OBS to display the window when a commercial plays.

## _Console_

Go to this tab to see everything that NHLGames logs. Any error or warning will show up here. Click on `Copy to clipboard` if you get an issue and want to report it on Github. Paste the log text when opening an issue.

# _Support_

Having an issue with NHLGames? Head to our [Wiki](https://github.com/NHLGames/NHLGames/wiki) to find a fix. Look at the side bar, on the right, to navigate between known issues. If you can't find it, feel free to open an [issue](https://github.com/NHLGames/NHLGames/issues).

# _Chromecast_

NHLGames doesn't support Chromecast, but VLC 3.0 player and Google Chrome does. Follow these steps if you want to play the game on your TV.

## _VLC 3.0_

![image](https://user-images.githubusercontent.com/23088305/37436787-15ef5fe2-27c0-11e8-8a47-b0a25b40a598.png)

## _Google Chrome_

![image](https://cloud.githubusercontent.com/assets/23088305/25557771/3570cf2a-2ce6-11e7-980a-b605b93c66dc.png)

3. Select a pc monitor you want to share. Make sure audio share is checked.

<img src="https://cloud.githubusercontent.com/assets/23088305/25556591/3145542a-2ccd-11e7-8ba4-d4947e2bb84f.png" width="460"/>

4. Use NHLGames to get a stream, once the game plays, move the media player window to the right monitor and enjoy the show.

<img src="https://cloud.githubusercontent.com/assets/23088305/25556617/a6caab1e-2ccd-11e7-89d3-c9177a997ed1.png" width="300"/>

# _Phones and TVs_

You can redirect the stream over the Internet by using VLC player output and host it.  
Open NHLGames, go to settings, select VLC as your default and turn on player args.  
Type `--sout=#http{mux=ts,dst=:8080/stream}`.  
Click on a stream, VLC should open after accepting new configs to your firewall.  
Go on your phone and use a player such as _MPV Mobile App_ to open the link `ip:8080/stream` replace `ip` by your external ip (internet/WAN) (google `my ip`) or by your internal ip (local/LAN) (cmd.exe `ipconfig`)

# _Contribute_

NHLGames is coded in VB.NET using Visual Studio and .Net Framework 4.5. If you want to contribute : [Follow the guidelines](CONTRIBUTING.md)

Thanks to our [contributors](https://github.com/NHLGames/NHLGames/graphs/contributors)

# _Donation_

[Donate via Paypal](https://streamlabs.com/melnykout)  
Donate via Bitcoin: `17uSfctCE4n5uLAHqZQEozqEiLafSaUgQL`

# _Download_

### Windows: [Lastest release](https://github.com/NHLGames/NHLGames/releases)
