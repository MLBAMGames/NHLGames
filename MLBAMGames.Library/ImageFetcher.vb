Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports Svg

Namespace Utilities
    Public Class ImageFetcher
        Public Shared Function GetEmbeddedImage(fileName As String) As Image
            Dim image As Image = Nothing
            Dim myAssembly As Assembly = Assembly.GetExecutingAssembly()
            Using s As Stream = myAssembly.GetManifestResourceStream($"NHLGames.{fileName.ToLower()}.png")
                If s Is Nothing Then Return Nothing
                s.Position = 0
                image = Image.FromStream(s)
            End Using
            Return image
        End Function

        ' to test svg images in app (dev)
        Private Shared Function GetEmbeddedImageSvg(fileName As String) As Bitmap
            Dim image As Bitmap = Nothing
            Dim myAssembly As Assembly = Assembly.GetExecutingAssembly()
            Using s As Stream = myAssembly.GetManifestResourceStream($"NHLGames.{fileName.ToLower()}.svg")
                If s Is Nothing Then Return Nothing
                s.Position = 0
                image = (SvgDocument.Open(Of SvgDocument)(s)).Draw()
            End Using
            Return image
        End Function

        ' to recreate all png images in output (dev)
        Private Shared Sub ImagesFromEmbeddedSvg()
            Dim myAssembly As Assembly = Assembly.GetExecutingAssembly()
            Dim files = New String() {"nhlgames", "alt", "att", "bs", "cbc", "espn", "fs", "msg", "nbc", "nesn", "rds", "root", "sn", "tsn", "tvas", "wgn", "broken", "cam", "cam_left", "cam_right", "cam_ref", "cam_star", "cam3way", "cam6way", "date_d", "date_l", "down_d", "down_l", "download", "left_d", "left_l", "live_0", "live_1", "live_2", "mpc", "mpv", "refresh_d", "refresh_l", "right_d", "right_l", "up_d", "up_l", "vlc", "ana_d", "ana_l", "ari_d", "ari_l", "bos_d", "bos_l", "buf_d", "buf_l", "car_d", "car_l", "cbj_l", "cbj_d", "cgy_d", "cgy_l", "chi_d", "chi_l", "col_d", "col_l", "dal_d", "dal_l", "det_d", "det_l", "edm_d", "edm_l", "fla_d", "fla_l", "lak_d", "lak_l", "min_d", "min_l", "mtl_d", "mtl_l", "nhl_d", "nhl_l", "njd_l", "njd_d", "nsh_l", "nsh_d", "nyi_d", "nyi_l", "nyr_d", "nyr_l", "ott_d", "ott_l", "phi_d", "phi_l", "pit_d", "pit_l", "sjs_d", "sjs_l", "stl_d", "stl_l", "tbl_d", "tbl_l", "tor_d", "tor_l", "van_d", "van_l", "vgk_d", "vgk_l", "wpg_d", "wpg_l", "wsh_d", "wsh_l"}

            For Each f In files
                Using s As Stream = myAssembly.GetManifestResourceStream($"NHLGames.{f.ToLower()}.svg")
                    If s IsNot Nothing Then
                        s.Position = 0
                        Dim x = (SvgDocument.Open(Of SvgDocument)(s)).Draw()
                        x.Save($"c:/output/{f}.png")
                    End If
                End Using
            Next
        End Sub
    End Class
End Namespace
