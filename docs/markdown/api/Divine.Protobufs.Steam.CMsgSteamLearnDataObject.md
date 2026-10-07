# <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataObject"></a> Class CMsgSteamLearnDataObject

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnDataObject : IMessage<CMsgSteamLearnDataObject>, IEquatable<CMsgSteamLearnDataObject>, IDeepCloneable<CMsgSteamLearnDataObject>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnDataObject](Divine.Protobufs.Steam.CMsgSteamLearnDataObject.md)

#### Implements

IMessage<CMsgSteamLearnDataObject\>, 
[IEquatable<CMsgSteamLearnDataObject\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnDataObject\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnDataObject\>\(CMsgSteamLearnDataObject, params CMsgSteamLearnDataObject\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataObject__ctor"></a> CMsgSteamLearnDataObject\(\)

```csharp
public CMsgSteamLearnDataObject()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataObject__ctor_Divine_Protobufs_Steam_CMsgSteamLearnDataObject_"></a> CMsgSteamLearnDataObject\(CMsgSteamLearnDataObject\)

```csharp
public CMsgSteamLearnDataObject(CMsgSteamLearnDataObject other)
```

#### Parameters

`other` [CMsgSteamLearnDataObject](Divine.Protobufs.Steam.CMsgSteamLearnDataObject.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataObject_ElementsFieldNumber"></a> ElementsFieldNumber

```csharp
public const int ElementsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataObject_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataObject_Elements"></a> Elements

```csharp
public RepeatedField<CMsgSteamLearnDataElement> Elements { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearnDataElement](Divine.Protobufs.Steam.CMsgSteamLearnDataElement.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataObject_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnDataObject> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnDataObject](Divine.Protobufs.Steam.CMsgSteamLearnDataObject.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataObject_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataObject_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnDataObject Clone()
```

#### Returns

 [CMsgSteamLearnDataObject](Divine.Protobufs.Steam.CMsgSteamLearnDataObject.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataObject_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataObject_Equals_Divine_Protobufs_Steam_CMsgSteamLearnDataObject_"></a> Equals\(CMsgSteamLearnDataObject\)

```csharp
public bool Equals(CMsgSteamLearnDataObject other)
```

#### Parameters

`other` [CMsgSteamLearnDataObject](Divine.Protobufs.Steam.CMsgSteamLearnDataObject.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataObject_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataObject_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearnDataObject_"></a> MergeFrom\(CMsgSteamLearnDataObject\)

```csharp
public void MergeFrom(CMsgSteamLearnDataObject other)
```

#### Parameters

`other` [CMsgSteamLearnDataObject](Divine.Protobufs.Steam.CMsgSteamLearnDataObject.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataObject_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataObject_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataObject_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

