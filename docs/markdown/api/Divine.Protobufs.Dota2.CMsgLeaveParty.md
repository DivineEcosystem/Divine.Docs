# <a id="Divine_Protobufs_Dota2_CMsgLeaveParty"></a> Class CMsgLeaveParty

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLeaveParty : IMessage<CMsgLeaveParty>, IEquatable<CMsgLeaveParty>, IDeepCloneable<CMsgLeaveParty>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLeaveParty](Divine.Protobufs.Dota2.CMsgLeaveParty.md)

#### Implements

IMessage<CMsgLeaveParty\>, 
[IEquatable<CMsgLeaveParty\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLeaveParty\>, 
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
[EnumerableExtensions.In<CMsgLeaveParty\>\(CMsgLeaveParty, params CMsgLeaveParty\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLeaveParty__ctor"></a> CMsgLeaveParty\(\)

```csharp
public CMsgLeaveParty()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeaveParty__ctor_Divine_Protobufs_Dota2_CMsgLeaveParty_"></a> CMsgLeaveParty\(CMsgLeaveParty\)

```csharp
public CMsgLeaveParty(CMsgLeaveParty other)
```

#### Parameters

`other` [CMsgLeaveParty](Divine.Protobufs.Dota2.CMsgLeaveParty.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLeaveParty_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLeaveParty_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLeaveParty> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLeaveParty](Divine.Protobufs.Dota2.CMsgLeaveParty.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLeaveParty_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaveParty_Clone"></a> Clone\(\)

```csharp
public CMsgLeaveParty Clone()
```

#### Returns

 [CMsgLeaveParty](Divine.Protobufs.Dota2.CMsgLeaveParty.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeaveParty_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaveParty_Equals_Divine_Protobufs_Dota2_CMsgLeaveParty_"></a> Equals\(CMsgLeaveParty\)

```csharp
public bool Equals(CMsgLeaveParty other)
```

#### Parameters

`other` [CMsgLeaveParty](Divine.Protobufs.Dota2.CMsgLeaveParty.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaveParty_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaveParty_MergeFrom_Divine_Protobufs_Dota2_CMsgLeaveParty_"></a> MergeFrom\(CMsgLeaveParty\)

```csharp
public void MergeFrom(CMsgLeaveParty other)
```

#### Parameters

`other` [CMsgLeaveParty](Divine.Protobufs.Dota2.CMsgLeaveParty.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeaveParty_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLeaveParty_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLeaveParty_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

