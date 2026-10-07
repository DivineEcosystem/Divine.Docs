# <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID"></a> Class CSVCMsg\_ServerSteamID

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_ServerSteamID : IMessage<CSVCMsg_ServerSteamID>, IEquatable<CSVCMsg_ServerSteamID>, IDeepCloneable<CSVCMsg_ServerSteamID>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_ServerSteamID](Divine.Protobufs.Dota2.CSVCMsg\_ServerSteamID.md)

#### Implements

IMessage<CSVCMsg\_ServerSteamID\>, 
[IEquatable<CSVCMsg\_ServerSteamID\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_ServerSteamID\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CSVCMsg\_ServerSteamID\>\(CSVCMsg\_ServerSteamID, params CSVCMsg\_ServerSteamID\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID__ctor"></a> CSVCMsg\_ServerSteamID\(\)

```csharp
public CSVCMsg_ServerSteamID()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID__ctor_Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_"></a> CSVCMsg\_ServerSteamID\(CSVCMsg\_ServerSteamID\)

```csharp
public CSVCMsg_ServerSteamID(CSVCMsg_ServerSteamID other)
```

#### Parameters

`other` [CSVCMsg\_ServerSteamID](Divine.Protobufs.Dota2.CSVCMsg\_ServerSteamID.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_ServerSteamID> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_ServerSteamID](Divine.Protobufs.Dota2.CSVCMsg\_ServerSteamID.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_ServerSteamID Clone()
```

#### Returns

 [CSVCMsg\_ServerSteamID](Divine.Protobufs.Dota2.CSVCMsg\_ServerSteamID.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_Equals_Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_"></a> Equals\(CSVCMsg\_ServerSteamID\)

```csharp
public bool Equals(CSVCMsg_ServerSteamID other)
```

#### Parameters

`other` [CSVCMsg\_ServerSteamID](Divine.Protobufs.Dota2.CSVCMsg\_ServerSteamID.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_"></a> MergeFrom\(CSVCMsg\_ServerSteamID\)

```csharp
public void MergeFrom(CSVCMsg_ServerSteamID other)
```

#### Parameters

`other` [CSVCMsg\_ServerSteamID](Divine.Protobufs.Dota2.CSVCMsg\_ServerSteamID.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerSteamID_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

