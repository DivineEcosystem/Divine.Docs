# <a id="Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged"></a> Class CMsgGCToGCWebAPIAccountChanged

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCWebAPIAccountChanged : IMessage<CMsgGCToGCWebAPIAccountChanged>, IEquatable<CMsgGCToGCWebAPIAccountChanged>, IDeepCloneable<CMsgGCToGCWebAPIAccountChanged>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCWebAPIAccountChanged](Divine.Protobufs.Dota2.CMsgGCToGCWebAPIAccountChanged.md)

#### Implements

IMessage<CMsgGCToGCWebAPIAccountChanged\>, 
[IEquatable<CMsgGCToGCWebAPIAccountChanged\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCWebAPIAccountChanged\>, 
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
[EnumerableExtensions.In<CMsgGCToGCWebAPIAccountChanged\>\(CMsgGCToGCWebAPIAccountChanged, params CMsgGCToGCWebAPIAccountChanged\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged__ctor"></a> CMsgGCToGCWebAPIAccountChanged\(\)

```csharp
public CMsgGCToGCWebAPIAccountChanged()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged__ctor_Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged_"></a> CMsgGCToGCWebAPIAccountChanged\(CMsgGCToGCWebAPIAccountChanged\)

```csharp
public CMsgGCToGCWebAPIAccountChanged(CMsgGCToGCWebAPIAccountChanged other)
```

#### Parameters

`other` [CMsgGCToGCWebAPIAccountChanged](Divine.Protobufs.Dota2.CMsgGCToGCWebAPIAccountChanged.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCWebAPIAccountChanged> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCWebAPIAccountChanged](Divine.Protobufs.Dota2.CMsgGCToGCWebAPIAccountChanged.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCWebAPIAccountChanged Clone()
```

#### Returns

 [CMsgGCToGCWebAPIAccountChanged](Divine.Protobufs.Dota2.CMsgGCToGCWebAPIAccountChanged.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged_Equals_Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged_"></a> Equals\(CMsgGCToGCWebAPIAccountChanged\)

```csharp
public bool Equals(CMsgGCToGCWebAPIAccountChanged other)
```

#### Parameters

`other` [CMsgGCToGCWebAPIAccountChanged](Divine.Protobufs.Dota2.CMsgGCToGCWebAPIAccountChanged.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged_"></a> MergeFrom\(CMsgGCToGCWebAPIAccountChanged\)

```csharp
public void MergeFrom(CMsgGCToGCWebAPIAccountChanged other)
```

#### Parameters

`other` [CMsgGCToGCWebAPIAccountChanged](Divine.Protobufs.Dota2.CMsgGCToGCWebAPIAccountChanged.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCWebAPIAccountChanged_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

