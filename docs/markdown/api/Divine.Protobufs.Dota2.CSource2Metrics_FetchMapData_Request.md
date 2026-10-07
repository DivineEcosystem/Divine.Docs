# <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request"></a> Class CSource2Metrics\_FetchMapData\_Request

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSource2Metrics_FetchMapData_Request : IMessage<CSource2Metrics_FetchMapData_Request>, IEquatable<CSource2Metrics_FetchMapData_Request>, IDeepCloneable<CSource2Metrics_FetchMapData_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSource2Metrics\_FetchMapData\_Request](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Request.md)

#### Implements

IMessage<CSource2Metrics\_FetchMapData\_Request\>, 
[IEquatable<CSource2Metrics\_FetchMapData\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSource2Metrics\_FetchMapData\_Request\>, 
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
[EnumerableExtensions.In<CSource2Metrics\_FetchMapData\_Request\>\(CSource2Metrics\_FetchMapData\_Request, params CSource2Metrics\_FetchMapData\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request__ctor"></a> CSource2Metrics\_FetchMapData\_Request\(\)

```csharp
public CSource2Metrics_FetchMapData_Request()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request__ctor_Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_"></a> CSource2Metrics\_FetchMapData\_Request\(CSource2Metrics\_FetchMapData\_Request\)

```csharp
public CSource2Metrics_FetchMapData_Request(CSource2Metrics_FetchMapData_Request other)
```

#### Parameters

`other` [CSource2Metrics\_FetchMapData\_Request](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Request.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_GameModeFieldNumber"></a> GameModeFieldNumber

```csharp
public const int GameModeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_GameTypeFieldNumber"></a> GameTypeFieldNumber

```csharp
public const int GameTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_MapNameFieldNumber"></a> MapNameFieldNumber

```csharp
public const int MapNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_ParamFieldNumber"></a> ParamFieldNumber

```csharp
public const int ParamFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_TimeSpanFieldNumber"></a> TimeSpanFieldNumber

```csharp
public const int TimeSpanFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_GameMode"></a> GameMode

```csharp
public uint GameMode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_GameType"></a> GameType

```csharp
public uint GameType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_HasGameMode"></a> HasGameMode

```csharp
public bool HasGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_HasGameType"></a> HasGameType

```csharp
public bool HasGameType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_HasMapName"></a> HasMapName

```csharp
public bool HasMapName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_HasParam"></a> HasParam

```csharp
public bool HasParam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_HasTimeSpan"></a> HasTimeSpan

```csharp
public bool HasTimeSpan { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_MapName"></a> MapName

```csharp
public string MapName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_Param"></a> Param

```csharp
public string Param { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_Parser"></a> Parser

```csharp
public static MessageParser<CSource2Metrics_FetchMapData_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CSource2Metrics\_FetchMapData\_Request](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Request.md)\>

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_TimeSpan"></a> TimeSpan

```csharp
public uint TimeSpan { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_ClearGameMode"></a> ClearGameMode\(\)

```csharp
public void ClearGameMode()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_ClearGameType"></a> ClearGameType\(\)

```csharp
public void ClearGameType()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_ClearMapName"></a> ClearMapName\(\)

```csharp
public void ClearMapName()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_ClearParam"></a> ClearParam\(\)

```csharp
public void ClearParam()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_ClearTimeSpan"></a> ClearTimeSpan\(\)

```csharp
public void ClearTimeSpan()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_Clone"></a> Clone\(\)

```csharp
public CSource2Metrics_FetchMapData_Request Clone()
```

#### Returns

 [CSource2Metrics\_FetchMapData\_Request](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Request.md)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_Equals_Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_"></a> Equals\(CSource2Metrics\_FetchMapData\_Request\)

```csharp
public bool Equals(CSource2Metrics_FetchMapData_Request other)
```

#### Parameters

`other` [CSource2Metrics\_FetchMapData\_Request](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_MergeFrom_Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_"></a> MergeFrom\(CSource2Metrics\_FetchMapData\_Request\)

```csharp
public void MergeFrom(CSource2Metrics_FetchMapData_Request other)
```

#### Parameters

`other` [CSource2Metrics\_FetchMapData\_Request](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Request.md)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

