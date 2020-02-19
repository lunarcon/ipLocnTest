# ipLocnTest
Get decently featured maps in .NET, with no Map API involved on your end!

<p align="center">
  <img src="ipLocnTest/sq.png" width="800">
</p>

- Supports Satellite view (with and without labels) and Regular view (with labels).
- Default Draggable (Through left mouse button) and Zoomable (Through Scroll Wheel), But also provides static mode (higher resolution) (with buttons for zoom, etc)
- Navigates to given coordinates
- Supports Geolocation (PS: sometimes it doesn't work on the first try)(also your location should be on)
- Saves image directly to your desktop

## Latest Additions
<ul>
<li>Added circular Navigation controls for static map. 🆕 *Now they are dark.*
</ul><br>
<p align = "left">
  <img src="ipLocnTest/nv.png" width="250">
</p><br>
<ul>
<li>🆕 Menu items now have icons.
</ul><br>
<p align = "left">
  <img src="ipLocnTest/nbar.png" width="250">
</p>
<ul>
<li> Improved zoom in static map.<br>
<li> Added Navigation hints to toolbar.<br>
<li> Minor design change.<br>
<li> Added search tip.
</ul><br>
## Geolocation - example

    Imports System.Device.Location

Put following code inside main class

    Dim txtlat As string,txtlong as string
    Private Sub LocateMe()
         Watcher = New GeoCoordinateWatcher()
         AddHandler Watcher.StatusChanged, AddressOf Watcher_StatusChanged
         Watcher.Start()
    End Sub
    Private Sub Watcher_StatusChanged(ByVal sender As Object, ByVal e As GeoPositionStatusChangedEventArgs)
        If e.Status = GeoPositionStatus.Ready Then
            If Watcher.Position.Location.IsUnknown Then
                txtlat = "Cannot find location data"
            Else
                txtlat = Watcher.Position.Location.Latitude.ToString()
                txtlong = Watcher.Position.Location.Longitude.ToString()
            End If
        End If       
        If Math.Abs(Val(txtlat)) > 0 Then
            Watcher.Stop()
        End if
    End Sub        

Call the LocateMe() sub when you require the location. For first use, a messagebox will pop up asking for permission to access location.
The values of txtlat and txtlong will be set to the latitude and longitude.
 Note that this is usually not instantaneous, and *may* fail on the first try
