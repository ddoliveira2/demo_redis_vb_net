Imports StackExchange.Redis

Public Class RedisConnection
    Private Shared _connection As ConnectionMultiplexer

    Public Shared Function GetConnection() As ConnectionMultiplexer

        If _connection Is Nothing OrElse Not _connection.IsConnected Then

            _connection = ConnectionMultiplexer.Connect(
                "localhost:6379"
            )

        End If

        Return _connection

    End Function
End Class
