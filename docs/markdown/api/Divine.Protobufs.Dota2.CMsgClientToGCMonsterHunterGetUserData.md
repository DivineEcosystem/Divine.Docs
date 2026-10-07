# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData"></a> Class CMsgClientToGCMonsterHunterGetUserData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterGetUserData : IMessage<CMsgClientToGCMonsterHunterGetUserData>, IEquatable<CMsgClientToGCMonsterHunterGetUserData>, IDeepCloneable<CMsgClientToGCMonsterHunterGetUserData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterGetUserData.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterGetUserData\>, 
[IEquatable<CMsgClientToGCMonsterHunterGetUserData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterGetUserData\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterGetUserData\>\(CMsgClientToGCMonsterHunterGetUserData, params CMsgClientToGCMonsterHunterGetUserData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData__ctor"></a> CMsgClientToGCMonsterHunterGetUserData\(\)

```csharp
public CMsgClientToGCMonsterHunterGetUserData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData_"></a> CMsgClientToGCMonsterHunterGetUserData\(CMsgClientToGCMonsterHunterGetUserData\)

```csharp
public CMsgClientToGCMonsterHunterGetUserData(CMsgClientToGCMonsterHunterGetUserData other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterGetUserData.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterGetUserData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterGetUserData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterGetUserData Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterGetUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData_"></a> Equals\(CMsgClientToGCMonsterHunterGetUserData\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterGetUserData other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterGetUserData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData_"></a> MergeFrom\(CMsgClientToGCMonsterHunterGetUserData\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterGetUserData other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterGetUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGetUserData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

