# <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats"></a> Class CMsgGCToGCUpdateSessionStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCUpdateSessionStats : IMessage<CMsgGCToGCUpdateSessionStats>, IEquatable<CMsgGCToGCUpdateSessionStats>, IDeepCloneable<CMsgGCToGCUpdateSessionStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCUpdateSessionStats](Divine.Protobufs.Dota2.CMsgGCToGCUpdateSessionStats.md)

#### Implements

IMessage<CMsgGCToGCUpdateSessionStats\>, 
[IEquatable<CMsgGCToGCUpdateSessionStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCUpdateSessionStats\>, 
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
[EnumerableExtensions.In<CMsgGCToGCUpdateSessionStats\>\(CMsgGCToGCUpdateSessionStats, params CMsgGCToGCUpdateSessionStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats__ctor"></a> CMsgGCToGCUpdateSessionStats\(\)

```csharp
public CMsgGCToGCUpdateSessionStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats__ctor_Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_"></a> CMsgGCToGCUpdateSessionStats\(CMsgGCToGCUpdateSessionStats\)

```csharp
public CMsgGCToGCUpdateSessionStats(CMsgGCToGCUpdateSessionStats other)
```

#### Parameters

`other` [CMsgGCToGCUpdateSessionStats](Divine.Protobufs.Dota2.CMsgGCToGCUpdateSessionStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_InLogonSurgeFieldNumber"></a> InLogonSurgeFieldNumber

```csharp
public const int InLogonSurgeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_ServerSessionsFieldNumber"></a> ServerSessionsFieldNumber

```csharp
public const int ServerSessionsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_UserSessionsFieldNumber"></a> UserSessionsFieldNumber

```csharp
public const int UserSessionsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_HasInLogonSurge"></a> HasInLogonSurge

```csharp
public bool HasInLogonSurge { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_HasServerSessions"></a> HasServerSessions

```csharp
public bool HasServerSessions { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_HasUserSessions"></a> HasUserSessions

```csharp
public bool HasUserSessions { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_InLogonSurge"></a> InLogonSurge

```csharp
public bool InLogonSurge { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCUpdateSessionStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCUpdateSessionStats](Divine.Protobufs.Dota2.CMsgGCToGCUpdateSessionStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_ServerSessions"></a> ServerSessions

```csharp
public uint ServerSessions { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_UserSessions"></a> UserSessions

```csharp
public uint UserSessions { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_ClearInLogonSurge"></a> ClearInLogonSurge\(\)

```csharp
public void ClearInLogonSurge()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_ClearServerSessions"></a> ClearServerSessions\(\)

```csharp
public void ClearServerSessions()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_ClearUserSessions"></a> ClearUserSessions\(\)

```csharp
public void ClearUserSessions()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCUpdateSessionStats Clone()
```

#### Returns

 [CMsgGCToGCUpdateSessionStats](Divine.Protobufs.Dota2.CMsgGCToGCUpdateSessionStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_Equals_Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_"></a> Equals\(CMsgGCToGCUpdateSessionStats\)

```csharp
public bool Equals(CMsgGCToGCUpdateSessionStats other)
```

#### Parameters

`other` [CMsgGCToGCUpdateSessionStats](Divine.Protobufs.Dota2.CMsgGCToGCUpdateSessionStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_"></a> MergeFrom\(CMsgGCToGCUpdateSessionStats\)

```csharp
public void MergeFrom(CMsgGCToGCUpdateSessionStats other)
```

#### Parameters

`other` [CMsgGCToGCUpdateSessionStats](Divine.Protobufs.Dota2.CMsgGCToGCUpdateSessionStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSessionStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

