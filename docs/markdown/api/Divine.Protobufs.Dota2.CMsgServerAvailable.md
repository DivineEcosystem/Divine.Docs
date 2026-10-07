# <a id="Divine_Protobufs_Dota2_CMsgServerAvailable"></a> Class CMsgServerAvailable

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerAvailable : IMessage<CMsgServerAvailable>, IEquatable<CMsgServerAvailable>, IDeepCloneable<CMsgServerAvailable>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerAvailable](Divine.Protobufs.Dota2.CMsgServerAvailable.md)

#### Implements

IMessage<CMsgServerAvailable\>, 
[IEquatable<CMsgServerAvailable\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerAvailable\>, 
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
[EnumerableExtensions.In<CMsgServerAvailable\>\(CMsgServerAvailable, params CMsgServerAvailable\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerAvailable__ctor"></a> CMsgServerAvailable\(\)

```csharp
public CMsgServerAvailable()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerAvailable__ctor_Divine_Protobufs_Dota2_CMsgServerAvailable_"></a> CMsgServerAvailable\(CMsgServerAvailable\)

```csharp
public CMsgServerAvailable(CMsgServerAvailable other)
```

#### Parameters

`other` [CMsgServerAvailable](Divine.Protobufs.Dota2.CMsgServerAvailable.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerAvailable_CustomGameInstallStatusFieldNumber"></a> CustomGameInstallStatusFieldNumber

```csharp
public const int CustomGameInstallStatusFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerAvailable_CustomGameInstallStatus"></a> CustomGameInstallStatus

```csharp
public CMsgCustomGameInstallStatus CustomGameInstallStatus { get; set; }
```

#### Property Value

 [CMsgCustomGameInstallStatus](Divine.Protobufs.Dota2.CMsgCustomGameInstallStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerAvailable_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerAvailable_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerAvailable> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerAvailable](Divine.Protobufs.Dota2.CMsgServerAvailable.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerAvailable_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerAvailable_Clone"></a> Clone\(\)

```csharp
public CMsgServerAvailable Clone()
```

#### Returns

 [CMsgServerAvailable](Divine.Protobufs.Dota2.CMsgServerAvailable.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerAvailable_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerAvailable_Equals_Divine_Protobufs_Dota2_CMsgServerAvailable_"></a> Equals\(CMsgServerAvailable\)

```csharp
public bool Equals(CMsgServerAvailable other)
```

#### Parameters

`other` [CMsgServerAvailable](Divine.Protobufs.Dota2.CMsgServerAvailable.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerAvailable_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerAvailable_MergeFrom_Divine_Protobufs_Dota2_CMsgServerAvailable_"></a> MergeFrom\(CMsgServerAvailable\)

```csharp
public void MergeFrom(CMsgServerAvailable other)
```

#### Parameters

`other` [CMsgServerAvailable](Divine.Protobufs.Dota2.CMsgServerAvailable.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerAvailable_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerAvailable_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerAvailable_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

