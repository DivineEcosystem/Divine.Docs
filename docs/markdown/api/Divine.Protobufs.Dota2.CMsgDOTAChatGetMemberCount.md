# <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount"></a> Class CMsgDOTAChatGetMemberCount

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAChatGetMemberCount : IMessage<CMsgDOTAChatGetMemberCount>, IEquatable<CMsgDOTAChatGetMemberCount>, IDeepCloneable<CMsgDOTAChatGetMemberCount>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAChatGetMemberCount](Divine.Protobufs.Dota2.CMsgDOTAChatGetMemberCount.md)

#### Implements

IMessage<CMsgDOTAChatGetMemberCount\>, 
[IEquatable<CMsgDOTAChatGetMemberCount\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAChatGetMemberCount\>, 
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
[EnumerableExtensions.In<CMsgDOTAChatGetMemberCount\>\(CMsgDOTAChatGetMemberCount, params CMsgDOTAChatGetMemberCount\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount__ctor"></a> CMsgDOTAChatGetMemberCount\(\)

```csharp
public CMsgDOTAChatGetMemberCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount__ctor_Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_"></a> CMsgDOTAChatGetMemberCount\(CMsgDOTAChatGetMemberCount\)

```csharp
public CMsgDOTAChatGetMemberCount(CMsgDOTAChatGetMemberCount other)
```

#### Parameters

`other` [CMsgDOTAChatGetMemberCount](Divine.Protobufs.Dota2.CMsgDOTAChatGetMemberCount.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_ChannelNameFieldNumber"></a> ChannelNameFieldNumber

```csharp
public const int ChannelNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_ChannelTypeFieldNumber"></a> ChannelTypeFieldNumber

```csharp
public const int ChannelTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_ChannelName"></a> ChannelName

```csharp
public string ChannelName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_ChannelType"></a> ChannelType

```csharp
public DOTAChatChannelType_t ChannelType { get; set; }
```

#### Property Value

 [DOTAChatChannelType\_t](Divine.Protobufs.Dota2.DOTAChatChannelType\_t.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_HasChannelName"></a> HasChannelName

```csharp
public bool HasChannelName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_HasChannelType"></a> HasChannelType

```csharp
public bool HasChannelType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAChatGetMemberCount> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAChatGetMemberCount](Divine.Protobufs.Dota2.CMsgDOTAChatGetMemberCount.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_ClearChannelName"></a> ClearChannelName\(\)

```csharp
public void ClearChannelName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_ClearChannelType"></a> ClearChannelType\(\)

```csharp
public void ClearChannelType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAChatGetMemberCount Clone()
```

#### Returns

 [CMsgDOTAChatGetMemberCount](Divine.Protobufs.Dota2.CMsgDOTAChatGetMemberCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_Equals_Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_"></a> Equals\(CMsgDOTAChatGetMemberCount\)

```csharp
public bool Equals(CMsgDOTAChatGetMemberCount other)
```

#### Parameters

`other` [CMsgDOTAChatGetMemberCount](Divine.Protobufs.Dota2.CMsgDOTAChatGetMemberCount.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_"></a> MergeFrom\(CMsgDOTAChatGetMemberCount\)

```csharp
public void MergeFrom(CMsgDOTAChatGetMemberCount other)
```

#### Parameters

`other` [CMsgDOTAChatGetMemberCount](Divine.Protobufs.Dota2.CMsgDOTAChatGetMemberCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCount_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

