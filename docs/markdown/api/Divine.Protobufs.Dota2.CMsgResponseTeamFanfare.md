# <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare"></a> Class CMsgResponseTeamFanfare

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgResponseTeamFanfare : IMessage<CMsgResponseTeamFanfare>, IEquatable<CMsgResponseTeamFanfare>, IDeepCloneable<CMsgResponseTeamFanfare>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgResponseTeamFanfare](Divine.Protobufs.Dota2.CMsgResponseTeamFanfare.md)

#### Implements

IMessage<CMsgResponseTeamFanfare\>, 
[IEquatable<CMsgResponseTeamFanfare\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgResponseTeamFanfare\>, 
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
[EnumerableExtensions.In<CMsgResponseTeamFanfare\>\(CMsgResponseTeamFanfare, params CMsgResponseTeamFanfare\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare__ctor"></a> CMsgResponseTeamFanfare\(\)

```csharp
public CMsgResponseTeamFanfare()
```

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare__ctor_Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_"></a> CMsgResponseTeamFanfare\(CMsgResponseTeamFanfare\)

```csharp
public CMsgResponseTeamFanfare(CMsgResponseTeamFanfare other)
```

#### Parameters

`other` [CMsgResponseTeamFanfare](Divine.Protobufs.Dota2.CMsgResponseTeamFanfare.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_FanfareBadguysFieldNumber"></a> FanfareBadguysFieldNumber

```csharp
public const int FanfareBadguysFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_FanfareGoodguysFieldNumber"></a> FanfareGoodguysFieldNumber

```csharp
public const int FanfareGoodguysFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_FanfareBadguys"></a> FanfareBadguys

```csharp
public uint FanfareBadguys { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_FanfareGoodguys"></a> FanfareGoodguys

```csharp
public uint FanfareGoodguys { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_HasFanfareBadguys"></a> HasFanfareBadguys

```csharp
public bool HasFanfareBadguys { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_HasFanfareGoodguys"></a> HasFanfareGoodguys

```csharp
public bool HasFanfareGoodguys { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_Parser"></a> Parser

```csharp
public static MessageParser<CMsgResponseTeamFanfare> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgResponseTeamFanfare](Divine.Protobufs.Dota2.CMsgResponseTeamFanfare.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_ClearFanfareBadguys"></a> ClearFanfareBadguys\(\)

```csharp
public void ClearFanfareBadguys()
```

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_ClearFanfareGoodguys"></a> ClearFanfareGoodguys\(\)

```csharp
public void ClearFanfareGoodguys()
```

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_Clone"></a> Clone\(\)

```csharp
public CMsgResponseTeamFanfare Clone()
```

#### Returns

 [CMsgResponseTeamFanfare](Divine.Protobufs.Dota2.CMsgResponseTeamFanfare.md)

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_Equals_Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_"></a> Equals\(CMsgResponseTeamFanfare\)

```csharp
public bool Equals(CMsgResponseTeamFanfare other)
```

#### Parameters

`other` [CMsgResponseTeamFanfare](Divine.Protobufs.Dota2.CMsgResponseTeamFanfare.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_MergeFrom_Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_"></a> MergeFrom\(CMsgResponseTeamFanfare\)

```csharp
public void MergeFrom(CMsgResponseTeamFanfare other)
```

#### Parameters

`other` [CMsgResponseTeamFanfare](Divine.Protobufs.Dota2.CMsgResponseTeamFanfare.md)

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgResponseTeamFanfare_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

