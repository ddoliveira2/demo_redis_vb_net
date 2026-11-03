Imports StackExchange.Redis
Public Class RedisHelper
    Private ReadOnly _db As IDatabase = RedisConnection.GetConnection().GetDatabase()



    Public Sub SetValue(key As String, value As String)
        _db.StringSet(key, value)
    End Sub
    Public Function GetValue(key As String) As String
        Return _db.StringGet(key).ToString()
    End Function

    Public Function Exists(key As String) As Boolean
        Return _db.KeyExists(key)
    End Function

    Public Sub Delete(key As String)
        _db.KeyDelete(key)
    End Sub

End Class
