# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing"></a> Class CDOTAClientMsg\_ChooseDeityBlessing

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_ChooseDeityBlessing : IMessage<CDOTAClientMsg_ChooseDeityBlessing>, IEquatable<CDOTAClientMsg_ChooseDeityBlessing>, IDeepCloneable<CDOTAClientMsg_ChooseDeityBlessing>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_ChooseDeityBlessing](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseDeityBlessing.md)

#### Implements

IMessage<CDOTAClientMsg\_ChooseDeityBlessing\>, 
[IEquatable<CDOTAClientMsg\_ChooseDeityBlessing\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_ChooseDeityBlessing\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_ChooseDeityBlessing\>\(CDOTAClientMsg\_ChooseDeityBlessing, params CDOTAClientMsg\_ChooseDeityBlessing\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing__ctor"></a> CDOTAClientMsg\_ChooseDeityBlessing\(\)

```csharp
public CDOTAClientMsg_ChooseDeityBlessing()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_"></a> CDOTAClientMsg\_ChooseDeityBlessing\(CDOTAClientMsg\_ChooseDeityBlessing\)

```csharp
public CDOTAClientMsg_ChooseDeityBlessing(CDOTAClientMsg_ChooseDeityBlessing other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChooseDeityBlessing](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseDeityBlessing.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_BlessingFieldNumber"></a> BlessingFieldNumber

```csharp
public const int BlessingFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_Blessing"></a> Blessing

```csharp
public int Blessing { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_HasBlessing"></a> HasBlessing

```csharp
public bool HasBlessing { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_ChooseDeityBlessing> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_ChooseDeityBlessing](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseDeityBlessing.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_ClearBlessing"></a> ClearBlessing\(\)

```csharp
public void ClearBlessing()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_ChooseDeityBlessing Clone()
```

#### Returns

 [CDOTAClientMsg\_ChooseDeityBlessing](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseDeityBlessing.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_"></a> Equals\(CDOTAClientMsg\_ChooseDeityBlessing\)

```csharp
public bool Equals(CDOTAClientMsg_ChooseDeityBlessing other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChooseDeityBlessing](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseDeityBlessing.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_"></a> MergeFrom\(CDOTAClientMsg\_ChooseDeityBlessing\)

```csharp
public void MergeFrom(CDOTAClientMsg_ChooseDeityBlessing other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChooseDeityBlessing](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseDeityBlessing.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseDeityBlessing_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

