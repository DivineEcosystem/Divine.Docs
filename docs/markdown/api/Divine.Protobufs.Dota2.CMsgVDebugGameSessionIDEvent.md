# <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent"></a> Class CMsgVDebugGameSessionIDEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgVDebugGameSessionIDEvent : IMessage<CMsgVDebugGameSessionIDEvent>, IEquatable<CMsgVDebugGameSessionIDEvent>, IDeepCloneable<CMsgVDebugGameSessionIDEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgVDebugGameSessionIDEvent](Divine.Protobufs.Dota2.CMsgVDebugGameSessionIDEvent.md)

#### Implements

IMessage<CMsgVDebugGameSessionIDEvent\>, 
[IEquatable<CMsgVDebugGameSessionIDEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgVDebugGameSessionIDEvent\>, 
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
[EnumerableExtensions.In<CMsgVDebugGameSessionIDEvent\>\(CMsgVDebugGameSessionIDEvent, params CMsgVDebugGameSessionIDEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent__ctor"></a> CMsgVDebugGameSessionIDEvent\(\)

```csharp
public CMsgVDebugGameSessionIDEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent__ctor_Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_"></a> CMsgVDebugGameSessionIDEvent\(CMsgVDebugGameSessionIDEvent\)

```csharp
public CMsgVDebugGameSessionIDEvent(CMsgVDebugGameSessionIDEvent other)
```

#### Parameters

`other` [CMsgVDebugGameSessionIDEvent](Divine.Protobufs.Dota2.CMsgVDebugGameSessionIDEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_ClientidFieldNumber"></a> ClientidFieldNumber

```csharp
public const int ClientidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_GamesessionidFieldNumber"></a> GamesessionidFieldNumber

```csharp
public const int GamesessionidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_Clientid"></a> Clientid

```csharp
public int Clientid { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_Gamesessionid"></a> Gamesessionid

```csharp
public string Gamesessionid { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_HasClientid"></a> HasClientid

```csharp
public bool HasClientid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_HasGamesessionid"></a> HasGamesessionid

```csharp
public bool HasGamesessionid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgVDebugGameSessionIDEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgVDebugGameSessionIDEvent](Divine.Protobufs.Dota2.CMsgVDebugGameSessionIDEvent.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_ClearClientid"></a> ClearClientid\(\)

```csharp
public void ClearClientid()
```

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_ClearGamesessionid"></a> ClearGamesessionid\(\)

```csharp
public void ClearGamesessionid()
```

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_Clone"></a> Clone\(\)

```csharp
public CMsgVDebugGameSessionIDEvent Clone()
```

#### Returns

 [CMsgVDebugGameSessionIDEvent](Divine.Protobufs.Dota2.CMsgVDebugGameSessionIDEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_Equals_Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_"></a> Equals\(CMsgVDebugGameSessionIDEvent\)

```csharp
public bool Equals(CMsgVDebugGameSessionIDEvent other)
```

#### Parameters

`other` [CMsgVDebugGameSessionIDEvent](Divine.Protobufs.Dota2.CMsgVDebugGameSessionIDEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_"></a> MergeFrom\(CMsgVDebugGameSessionIDEvent\)

```csharp
public void MergeFrom(CMsgVDebugGameSessionIDEvent other)
```

#### Parameters

`other` [CMsgVDebugGameSessionIDEvent](Divine.Protobufs.Dota2.CMsgVDebugGameSessionIDEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgVDebugGameSessionIDEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

