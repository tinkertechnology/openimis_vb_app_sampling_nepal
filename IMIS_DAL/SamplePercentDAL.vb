''Copyright (c) 2016-2017 Swiss Agency for Development and Cooperation (SDC)
''
''The program users must agree to the following terms:
''
''Copyright notices
''This program is free software: you can redistribute it and/or modify it under the terms of the GNU AGPL v3 License as published by the 
''Free Software Foundation, version 3 of the License.
''This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of 
''MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU AGPL v3 License for more details www.gnu.org.
''
''Disclaimer of Warranty
''There is no warranty for the program, to the extent permitted by applicable law; except when otherwise stated in writing the copyright 
''holders and/or other parties provide the program "as is" without warranty of any kind, either expressed or implied, including, but not 
''limited to, the implied warranties of merchantability and fitness for a particular purpose. The entire risk as to the quality and 
''performance of the program is with you. Should the program prove defective, you assume the cost of all necessary servicing, repair or correction.
''
''Limitation of Liability 
''In no event unless required by applicable law or agreed to in writing will any copyright holder, or any other party who modifies and/or 
''conveys the program as permitted above, be liable to you for damages, including any general, special, incidental or consequential damages 
''arising out of the use or inability to use the program (including but not limited to loss of data or data being rendered inaccurate or losses 
''sustained by you or third parties or a failure of the program to operate with any other programs), even if such holder or other party has been 
''advised of the possibility of such damages.
''
''In case of dispute arising out or in relation to the use of the program, it is subject to the public law of Switzerland. The place of jurisdiction is Berne.
'
' 
'

Public Class SamplePercentDAL
    Dim data As New ExactSQL

    Public Function CheckExistsID() As Integer?
        Dim sSql As String

        sSql = "select MAX(ID) from tblSamplePercentSetting"

        data.setSQLCommand(sSql, CommandType.Text)


        data.ExecuteCommand()
        Dim maxID = data.Filldata
        'If IsDBNull(maxID) Or maxID Is Nothing Then
        '    maxID(0)(0) = 0
        'End If
        Dim x = maxID(0)(0)
        If IsDBNull(x) Then
            Return 0
        End If
        Return x
        Return maxID(0)(0) 'data.Filldata'
    End Function
    Public Sub AddUpdate(ByRef eSamplePercent As IMIS_EN.tblSamplePercent)
        Dim data As New ExactSQL


        Try
            Dim check = CheckExistsID()
            If check = 0 Then
                Dim sSql As String
                sSql = "insert into tblSamplePercentSetting 
                (PrivateMinValue, PrivateMaxValue, PrivatePercent,PublicMinValue, PublicMaxvalue, PublicPercent) 
                values(@MinValuePrivate,@MaxValuePrivate,@PrivatePercent,@MinValuePublic,@MaxValuePublic,@PercentPublic)"
                data.setSQLCommand(sSql, CommandType.Text)
            Else

                Dim sSQL As String = "update tblSamplePercentSetting set PrivateMinValue = @MinValuePrivate,PrivateMaxValue=@MaxValuePrivate,PrivatePercent = @PrivatePercent,"

                sSQL += "PublicMinValue = @MinValuePublic , PublicMaxValue=@MaxValuePublic, PublicPercent=@PercentPublic "

                Dim jpt = sSQL
                sSQL += "where ID=" + check.ToString
                data.setSQLCommand(sSQL, CommandType.Text)
            End If


            data.params("@MinValuePrivate", SqlDbType.Decimal, Convert.ToDecimal(eSamplePercent.MinValuePrivate))
            data.params("@MaxValuePrivate", SqlDbType.Decimal, Convert.ToDecimal(eSamplePercent.MaxValuePrivate))
            data.params("@PrivatePercent", SqlDbType.Decimal, Convert.ToDecimal(eSamplePercent.PercentPrivate))
            data.params("@MinValuePublic", SqlDbType.Decimal, Convert.ToDecimal(eSamplePercent.MinValuePublic))
            data.params("@MaxValuePublic", SqlDbType.Decimal, Convert.ToDecimal(eSamplePercent.MaxValuePublic))
            data.params("@PercentPublic", SqlDbType.Decimal, Convert.ToDecimal(eSamplePercent.PercentPublic))

            data.ExecuteCommand()

            'Dim sSQL As String = "update tblSamplePercentSetting set , tblSamplePercentSetting.PrivateMinValue = @MinValuePrivate,tblSamplingPercentSetting.PrivateMaxValue=@MaxValuePrivate,tblSamplingPercentSetting.PrivatePercent = @PrivatePercent "

            '    sSQL += "tblSamplingPercentSetting.PublicMinValue = @MinValuePublic , PublicMinValue=@MaxValuePublic, PublicPercent=@PublicPercent"

            '    data.setSQLCommand(sSQL, CommandType.Text)


            'data.params("@MinValuePrivate", SqlDbType.Decimal, Convert.ToDecimal(eSamplePercent.MinValuePrivate))
            'data.params("@MaxValuePrivate", SqlDbType.Decimal, Convert.ToDecimal(eSamplePercent.MaxValuePrivate))
            'data.params("@PrivatePercent", SqlDbType.Float, Convert.ToDouble(eSamplePercent.PercentPrivate))
            'data.params("@MinValuePublic", SqlDbType.Decimal, Convert.ToDecimal(eSamplePercent.MinValuePublic))
            'data.params("@MinValuePrivate", SqlDbType.Decimal, Convert.ToDecimal(eSamplePercent.MinValuePublic))
            'data.params("@PercentPublic", SqlDbType.Decimal, Convert.ToDouble(eSamplePercent.PercentPublic))

        Catch ex As Exception
            Dim terobau = 1

        End Try



        'data.params("@PolicyID", SqlDbType.Int, ePremium.tblPolicy.PolicyID)



    End Sub

    Public Function LoadSamplePercentSetting() As DataTable
        Dim sSQL As String = "SELECT TOP 1  PrivateMinValue
          ,PrivateMaxValue
          ,PrivatePercent
          ,PublicMinValue
          ,PublicMaxValue
          ,PublicPercent  FROM tblSamplePercentSetting"
        Dim data As New ExactSQL

        data.setSQLCommand(sSQL, CommandType.Text)

        Dim dt As DataTable = data.Filldata

        Return dt

    End Function

End Class

