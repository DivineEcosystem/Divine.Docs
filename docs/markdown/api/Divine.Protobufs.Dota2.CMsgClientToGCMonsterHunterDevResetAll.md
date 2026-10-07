# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll"></a> Class CMsgClientToGCMonsterHunterDevResetAll

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterDevResetAll : IMessage<CMsgClientToGCMonsterHunterDevResetAll>, IEquatable<CMsgClientToGCMonsterHunterDevResetAll>, IDeepCloneable<CMsgClientToGCMonsterHunterDevResetAll>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterDevResetAll](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevResetAll.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterDevResetAll\>, 
[IEquatable<CMsgClientToGCMonsterHunterDevResetAll\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterDevResetAll\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterDevResetAll\>\(CMsgClientToGCMonsterHunterDevResetAll, params CMsgClientToGCMonsterHunterDevResetAll\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll__ctor"></a> CMsgClientToGCMonsterHunterDevResetAll\(\)

```csharp
public CMsgClientToGCMonsterHunterDevResetAll()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_"></a> CMsgClientToGCMonsterHunterDevResetAll\(CMsgClientToGCMonsterHunterDevResetAll\)

```csharp
public CMsgClientToGCMonsterHunterDevResetAll(CMsgClientToGCMonsterHunterDevResetAll other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevResetAll](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevResetAll.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_ResetCodexOnlyFieldNumber"></a> ResetCodexOnlyFieldNumber

```csharp
public const int ResetCodexOnlyFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_HasResetCodexOnly"></a> HasResetCodexOnly

```csharp
public bool HasResetCodexOnly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterDevResetAll> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterDevResetAll](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevResetAll.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_ResetCodexOnly"></a> ResetCodexOnly

```csharp
public bool ResetCodexOnly { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_ClearResetCodexOnly"></a> ClearResetCodexOnly\(\)

```csharp
public void ClearResetCodexOnly()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterDevResetAll Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterDevResetAll](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevResetAll.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_"></a> Equals\(CMsgClientToGCMonsterHunterDevResetAll\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterDevResetAll other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevResetAll](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevResetAll.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_"></a> MergeFrom\(CMsgClientToGCMonsterHunterDevResetAll\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterDevResetAll other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevResetAll](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevResetAll.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAll_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

