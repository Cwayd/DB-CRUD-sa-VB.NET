Imports MySql.Data.MySqlClient

Module DBConnection
    Public Function strstconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;Database=dbemployee;port=3306")
    End Function
    Public strcon As MySqlConnection = strstconnection()

End Module
