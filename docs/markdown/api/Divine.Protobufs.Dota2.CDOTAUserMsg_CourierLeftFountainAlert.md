# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert"></a> Class CDOTAUserMsg\_CourierLeftFountainAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_CourierLeftFountainAlert : IMessage<CDOTAUserMsg_CourierLeftFountainAlert>, IEquatable<CDOTAUserMsg_CourierLeftFountainAlert>, IDeepCloneable<CDOTAUserMsg_CourierLeftFountainAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_CourierLeftFountainAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierLeftFountainAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_CourierLeftFountainAlert\>, 
[IEquatable<CDOTAUserMsg\_CourierLeftFountainAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_CourierLeftFountainAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_CourierLeftFountainAlert\>\(CDOTAUserMsg\_CourierLeftFountainAlert, params CDOTAUserMsg\_CourierLeftFountainAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert__ctor"></a> CDOTAUserMsg\_CourierLeftFountainAlert\(\)

```csharp
public CDOTAUserMsg_CourierLeftFountainAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_"></a> CDOTAUserMsg\_CourierLeftFountainAlert\(CDOTAUserMsg\_CourierLeftFountainAlert\)

```csharp
public CDOTAUserMsg_CourierLeftFountainAlert(CDOTAUserMsg_CourierLeftFountainAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_CourierLeftFountainAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierLeftFountainAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_OwningPlayerIdFieldNumber"></a> OwningPlayerIdFieldNumber

```csharp
public const int OwningPlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_HasOwningPlayerId"></a> HasOwningPlayerId

```csharp
public bool HasOwningPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_OwningPlayerId"></a> OwningPlayerId

```csharp
public int OwningPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_CourierLeftFountainAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_CourierLeftFountainAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierLeftFountainAlert.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_ClearOwningPlayerId"></a> ClearOwningPlayerId\(\)

```csharp
public void ClearOwningPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_CourierLeftFountainAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_CourierLeftFountainAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierLeftFountainAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_"></a> Equals\(CDOTAUserMsg\_CourierLeftFountainAlert\)

```csharp
public bool Equals(CDOTAUserMsg_CourierLeftFountainAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_CourierLeftFountainAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierLeftFountainAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_"></a> MergeFrom\(CDOTAUserMsg\_CourierLeftFountainAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_CourierLeftFountainAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_CourierLeftFountainAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierLeftFountainAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierLeftFountainAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

