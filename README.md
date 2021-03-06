# FantasyDataSportsAPI

We have implemented for below sports API
- NFL(Football – version v3),
- Soccer ( version v2)
- NHL(Hockey –version v3)
- NBA(Basketball – version v3)
- MLB(Baseball –version v3)

 ### How to configure it ###

Add following section to in web.config file:
<pre>
&lt;configSections>
    &lt;section name="fantasyData" type="FantasyData.Configuration.FantasyDataSubscriptionRetrieverSection, FantasyData" />
    &lt;section name="fantasyDataSoccer" type="FantasyData.Configuration.FantasyDataSubscriptionRetrieverSection, FantasyData" />
    &lt;section name="fantasyDataNBA" type="FantasyData.Configuration.FantasyDataSubscriptionRetrieverSection, FantasyData"/>
    &lt;section name="fantasyDataNHL" type="FantasyData.Configuration.FantasyDataSubscriptionRetrieverSection, FantasyData" />
    &lt;section name="fantasyDataMLB" type="FantasyData.Configuration.FantasyDataSubscriptionRetrieverSection, FantasyData"/>
&lt;/configSections>
&lt;/p>
</pre>
Add following sections in configuration section in web.config file
<pre>
&lt;fantasyData defaultSubscription="RealTime">
  &lt;subscriptions>
    &lt;add name="RealTime" baseUrl="https://api.fantasydata.net/v3/nfl/" primarySubscriptionKey="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" secondarySubscriptionKey=" xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx "
         projectionPrimarySubscriptionKey="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" projectionSecondarySubscriptionKey="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"/>      
  &lt;/subscriptions>
&lt;/fantasyData>
&lt;fantasyDataSoccer defaultSubscription="RealTime">
  &lt;subscriptions>      
    &lt;add name="RealTime" baseUrl="https://api.fantasydata.net/v3/soccer/" primarySubscriptionKey="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" secondarySubscriptionKey=" xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx " 
         projectionPrimarySubscriptionKey="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" projectionSecondarySubscriptionKey="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"/>
  &lt;/subscriptions>
&lt;/fantasyDataSoccer>  
&lt;fantasyDataNHL defaultSubscription="RealTime">
  &lt;subscriptions>
    &lt;add name="RealTime" baseUrl="https://api.fantasydata.net/v3/nhl/" primarySubscriptionKey="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" secondarySubscriptionKey=" xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx "
         projectionPrimarySubscriptionKey="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" projectionSecondarySubscriptionKey="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"/>
  &lt;/subscriptions>
&lt;/fantasyDataNHL>
&lt;fantasyDataMLB defaultSubscription="RealTime">
  &lt;subscriptions>      
    &lt;add name="RealTime" baseUrl="https://api.fantasydata.net/v3/mlb/" primarySubscriptionKey="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" secondarySubscriptionKey=" xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx "
          projectionPrimarySubscriptionKey="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" projectionSecondarySubscriptionKey="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
         PlayByPlayPrimarySubscriptionKey="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"  PlayByPlaySecondarySubscriptionKey="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" />
  &lt;/subscriptions>
&lt;/fantasyDataMLB>
&lt;fantasyDataNBA defaultSubscription="RealTime">
  &lt;subscriptions>
    &lt;add name="RealTime" baseUrl="https://api.fantasydata.net/v3/nba/" primarySubscriptionKey="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" secondarySubscriptionKey="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" />
  &lt;/subscriptions>
&lt;/fantasyDataNBA>
</pre>
Note that base URL is stetic and add your subscription keys, you can use trial version from companies web site https://fantasydata.com/

Add DLLs as per requirements to implementation of sport game,  DLL for fantasyData and FantasyData.Utils are mendatory and other dll you can choose as per sport you want to implement,
Regarding sport game implementation, you need to import two DLL for e.g if you want to implement NFL than you need to import FantasyData.NFL.dll, and FantasyData.NFL.Entities

Refer below details to retrive API data,
<pre>
public class FantasyDataRepo
{
    private fantasyClient fantasyclient = null; 
    public FantasyDataRepo()
	{
		fantasyclient = new fantasyClient(); 
	}
	
	public bool NFLIsGameInProgress
	{
		return fantasyclient.SeasonService.IsGameInProgress;		
	}
	public Teams GetTeams()
	{
		return fantasyclient.TeamService.Get();
	}	
}
</pre>
